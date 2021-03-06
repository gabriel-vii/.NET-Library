﻿using CryptoApisLibrary.DataTypes;
using RestSharp.Deserializers;
using System.Collections.Generic;

namespace CryptoApisLibrary.ResponseTypes.Exchanges
{
    public class ExchangesAssetsResponse : BaseCollectionResponse
    {
        [DeserializeAs(Name = "payload")]
        public List<ExchangeAssets> Infos { get; protected set; } = new List<ExchangeAssets>();

        protected override IEnumerable<object> GetItems => Infos;
    }
}