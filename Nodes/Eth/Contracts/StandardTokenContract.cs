﻿using System;
using System.Collections.Generic;
using System.Numerics;
using System.Text;
using Nethereum;
using Nethereum.ABI.FunctionEncoding.Attributes;
using Nethereum.Contracts;

namespace NodeBlock.Plugin.Ethereum.Nodes.Eth.Contracts
{
    public class StandardTokenContract : ContractDeploymentMessage
    {

        public static string BYTECODE = "0x60806040523480156200001157600080fd5b50604051620016ac380380620016ac833981810160405260c08110156200003757600080fd5b8101908080519060200190929190805160405193929190846401000000008211156200006257600080fd5b838201915060208201858111156200007957600080fd5b82518660018202830111640100000000821117156200009757600080fd5b8083526020830192505050908051906020019080838360005b83811015620000cd578082015181840152602081019050620000b0565b50505050905090810190601f168015620000fb5780820380516001836020036101000a031916815260200191505b50604052602001805160405193929190846401000000008211156200011f57600080fd5b838201915060208201858111156200013657600080fd5b82518660018202830111640100000000821117156200015457600080fd5b8083526020830192505050908051906020019080838360005b838110156200018a5780820151818401526020810190506200016d565b50505050905090810190601f168015620001b85780820380516001836020036101000a031916815260200191505b50604052602001805190602001909291908051906020019092919080519060200190929190505050848484838360039080519060200190620001fc929190620004cf565b50826004908051906020019062000215929190620004cf565b5081600560006101000a81548160ff021916908360ff16021790555080600281905550505050508160068190555062000257866006546200026360201b60201c565b50505050505062000585565b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff16141562000307576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252601f8152602001807f45524332303a206d696e7420746f20746865207a65726f20616464726573730081525060200191505060405180910390fd5b6200031b600083836200044160201b60201c565b62000337816002546200044660201b620009d31790919060201c565b60028190555062000395816000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020546200044660201b620009d31790919060201c565b6000808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff16600073ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef836040518082815260200191505060405180910390a35050565b505050565b600080828401905083811015620004c5576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252601b8152602001807f536166654d6174683a206164646974696f6e206f766572666c6f77000000000081525060200191505060405180910390fd5b8091505092915050565b828054600181600116156101000203166002900490600052602060002090601f01602090048101928262000507576000855562000553565b82601f106200052257805160ff191683800117855562000553565b8280016001018555821562000553579182015b828111156200055257825182559160200191906001019062000535565b5b50905062000562919062000566565b5090565b5b808211156200058157600081600090555060010162000567565b5090565b61111780620005956000396000f3fe608060405234801561001057600080fd5b50600436106100b45760003560e01c80633950935111610071578063395093511461028157806370a08231146102e557806395d89b411461033d578063a457c2d7146103c0578063a9059cbb14610424578063dd62ed3e14610488576100b4565b806306fdde03146100b9578063095ea7b31461013c57806318160ddd146101a057806323b872dd146101be578063313ce56714610242578063378dc3dc14610263575b600080fd5b6100c1610500565b6040518080602001828103825283818151815260200191508051906020019080838360005b838110156101015780820151818401526020810190506100e6565b50505050905090810190601f16801561012e5780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b6101886004803603604081101561015257600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506105a2565b60405180821515815260200191505060405180910390f35b6101a86105c0565b6040518082815260200191505060405180910390f35b61022a600480360360608110156101d457600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506105ca565b60405180821515815260200191505060405180910390f35b61024a6106a3565b604051808260ff16815260200191505060405180910390f35b61026b6106ba565b6040518082815260200191505060405180910390f35b6102cd6004803603604081101561029757600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803590602001909291905050506106c4565b60405180821515815260200191505060405180910390f35b610327600480360360208110156102fb57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190505050610777565b6040518082815260200191505060405180910390f35b6103456107bf565b6040518080602001828103825283818151815260200191508051906020019080838360005b8381101561038557808201518184015260208101905061036a565b50505050905090810190601f1680156103b25780820380516001836020036101000a031916815260200191505b509250505060405180910390f35b61040c600480360360408110156103d657600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff16906020019092919080359060200190929190505050610861565b60405180821515815260200191505060405180910390f35b6104706004803603604081101561043a57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff1690602001909291908035906020019092919050505061092e565b60405180821515815260200191505060405180910390f35b6104ea6004803603604081101561049e57600080fd5b81019080803573ffffffffffffffffffffffffffffffffffffffff169060200190929190803573ffffffffffffffffffffffffffffffffffffffff16906020019092919050505061094c565b6040518082815260200191505060405180910390f35b606060038054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156105985780601f1061056d57610100808354040283529160200191610598565b820191906000526020600020905b81548152906001019060200180831161057b57829003601f168201915b5050505050905090565b60006105b66105af610a5b565b8484610a63565b6001905092915050565b6000600254905090565b60006105d7848484610c5a565b610698846105e3610a5b565b6106938560405180606001604052806028815260200161104c60289139600160008b73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff1681526020019081526020016000206000610649610a5b565b73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610f1b9092919063ffffffff16565b610a63565b600190509392505050565b6000600560009054906101000a900460ff16905090565b6000600654905090565b600061076d6106d1610a5b565b8461076885600160006106e2610a5b565b73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008973ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020546109d390919063ffffffff16565b610a63565b6001905092915050565b60008060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020549050919050565b606060048054600181600116156101000203166002900480601f0160208091040260200160405190810160405280929190818152602001828054600181600116156101000203166002900480156108575780601f1061082c57610100808354040283529160200191610857565b820191906000526020600020905b81548152906001019060200180831161083a57829003601f168201915b5050505050905090565b600061092461086e610a5b565b8461091f856040518060600160405280602581526020016110bd6025913960016000610898610a5b565b73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008a73ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610f1b9092919063ffffffff16565b610a63565b6001905092915050565b600061094261093b610a5b565b8484610c5a565b6001905092915050565b6000600160008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008373ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054905092915050565b600080828401905083811015610a51576040517f08c379a000000000000000000000000000000000000000000000000000000000815260040180806020018281038252601b8152602001807f536166654d6174683a206164646974696f6e206f766572666c6f77000000000081525060200191505060405180910390fd5b8091505092915050565b600033905090565b600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff161415610ae9576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260248152602001806110996024913960400191505060405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610b6f576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260228152602001806110046022913960400191505060405180910390fd5b80600160008573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002060008473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167f8c5be1e5ebec7d5bd14f71427d1e84f3dd0314c0f7b2291e5b200ac8c7c3b925836040518082815260200191505060405180910390a3505050565b600073ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff161415610ce0576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825260258152602001806110746025913960400191505060405180910390fd5b600073ffffffffffffffffffffffffffffffffffffffff168273ffffffffffffffffffffffffffffffffffffffff161415610d66576040517f08c379a0000000000000000000000000000000000000000000000000000000008152600401808060200182810382526023815260200180610fe16023913960400191505060405180910390fd5b610d71838383610fdb565b610ddc81604051806060016040528060268152602001611026602691396000808773ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002054610f1b9092919063ffffffff16565b6000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff16815260200190815260200160002081905550610e6f816000808573ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020546109d390919063ffffffff16565b6000808473ffffffffffffffffffffffffffffffffffffffff1673ffffffffffffffffffffffffffffffffffffffff168152602001908152602001600020819055508173ffffffffffffffffffffffffffffffffffffffff168373ffffffffffffffffffffffffffffffffffffffff167fddf252ad1be2c89b69c2b068fc378daa952ba7f163c4a11628f55a4df523b3ef836040518082815260200191505060405180910390a3505050565b6000838311158290610fc8576040517f08c379a00000000000000000000000000000000000000000000000000000000081526004018080602001828103825283818151815260200191508051906020019080838360005b83811015610f8d578082015181840152602081019050610f72565b50505050905090810190601f168015610fba5780820380516001836020036101000a031916815260200191505b509250505060405180910390fd5b5060008385039050809150509392505050565b50505056fe45524332303a207472616e7366657220746f20746865207a65726f206164647265737345524332303a20617070726f766520746f20746865207a65726f206164647265737345524332303a207472616e7366657220616d6f756e7420657863656564732062616c616e636545524332303a207472616e7366657220616d6f756e74206578636565647320616c6c6f77616e636545524332303a207472616e736665722066726f6d20746865207a65726f206164647265737345524332303a20617070726f76652066726f6d20746865207a65726f206164647265737345524332303a2064656372656173656420616c6c6f77616e63652062656c6f77207a65726fa2646970667358221220921375cc93790a105fa1e9850fe67f5c9a5de835f0a5687f521650b1ca2acc4864736f6c63430007040033";

        public StandardTokenContract() : base(BYTECODE) { }

        [Parameter("string", "_deployer")]
        public string Deployer { get; set; }

        [Parameter("string", "_name")]
        public string Name { get; set; }

        [Parameter("string", "_symbol")]
        public string Symbol { get; set; }

        [Parameter("uint8", "_decimals")]
        public sbyte Decimals { get; set; }

        [Parameter("uint256", "initialSupply_")]
        public BigInteger InitialSupply { get; set; }

        [Parameter("uint256", "_totalSupply")]
        public BigInteger TotalSupply { get; set; }


        [Function("balanceOf", "uint256")]
        public class BalanceOfFunction : FunctionMessage
        {
            [Parameter("address", "_owner", 1)]
            public string Owner { get; set; }
        }

        [Function("transfer", "bool")]
        public class TransferFunction : FunctionMessage
        {
            [Parameter("address", "_to", 1)]
            public string To { get; set; }

            [Parameter("uint256", "_value", 2)]
            public BigInteger TokenAmount { get; set; }
        }
    }
}
