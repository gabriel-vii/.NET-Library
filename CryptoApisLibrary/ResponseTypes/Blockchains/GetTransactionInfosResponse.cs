﻿using CryptoApisLibrary.DataTypes;
using RestSharp.Deserializers;
using System.Collections.Generic;
using CryptoApisLibrary.ResponseTypes.Blockchains.Payloads;

namespace CryptoApisLibrary.ResponseTypes.Blockchains
{
    public abstract class GetTransactionInfosResponse : BaseCollectionResponse
    { }

    public class GetBtcTransactionInfosResponse : GetTransactionInfosResponse
    {
        [DeserializeAs(Name = "payload")]
        public List<BtcTransaction> Transactions { get; protected set; } = new List<BtcTransaction>();

        protected override IEnumerable<object> GetItems => Transactions;
    }

    public class GetEthTransactionInfosResponse : GetTransactionInfosResponse
    {
        [DeserializeAs(Name = "payload")]
        public List<EthTransactionInfo> Transactions { get; protected set; } = new List<EthTransactionInfo>();

        protected override IEnumerable<object> GetItems => Transactions;
    }
}