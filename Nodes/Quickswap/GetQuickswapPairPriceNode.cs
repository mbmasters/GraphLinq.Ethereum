﻿using GraphQL;
using GraphQL.NewtonsoftJson;
using GraphQL.Types;
using Newtonsoft.Json;
using NodeBlock.Engine;
using NodeBlock.Engine.Attributes;
using NodeBlock.Plugin.Ethereum.Nodes.Quickswap.Entities;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Net.Http;
using System.Text;

namespace NodeBlock.Plugin.Ethereum.Nodes.Quickswap
{
    [NodeDefinition("GetQuickswapPairPriceNode", "Quickswap Get Pair Price", NodeTypeEnum.Function, "Quickswap")]
    [NodeGraphDescription("Return the pair price of an Quickswap pool as out parameters")]
    public class GetQuickswapPairPriceNode : Node
    {
        public GetQuickswapPairPriceNode(string id, BlockGraph graph)
          : base(id, graph, typeof(GetQuickswapPairPriceNode).Name)
        {
            this.InParameters.Add("pairAddress", new NodeParameter(this, "pairAddress", typeof(string), true));

            this.OutParameters.Add("token0Price", new NodeParameter(this, "token0Price", typeof(double), false));
            this.OutParameters.Add("token1Price", new NodeParameter(this, "token1Price", typeof(double), false));
        }

        private HttpClient client = new HttpClient();

        public override bool CanBeExecuted => true;

        public override bool CanExecute => true;

        public override bool OnExecution()
        {
            var query = JsonConvert.SerializeObject(new
            {
                query = $"{{ pair(id: \"{this.InParameters["pairAddress"].GetValue().ToString()}\") {{ token0Price, token1Price }} }}"
            });
            var content = new StringContent(query, Encoding.UTF8, "application/json");
            var response = client.PostAsync("https://api.thegraph.com/subgraphs/name/sameepsi/quickswap06", content).Result;
            var result = JsonConvert.DeserializeObject<QuickswapPairGraphPrice>(response.Content.ReadAsStringAsync().Result);

            this.OutParameters["token0Price"].SetValue(double.Parse(result.Root.Pair.Token0Price, CultureInfo.InvariantCulture));
            this.OutParameters["token1Price"].SetValue(double.Parse(result.Root.Pair.Token1Price, CultureInfo.InvariantCulture));

            return true;
        }
    }
}
