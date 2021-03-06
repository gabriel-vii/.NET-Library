﻿using CryptoApisLibrary.ResponseTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CryptoApisLibrary.Tests.Exchanges.Info
{
    [TestClass]
    public class AssetsMeta : BaseCollectionTest
    {
        protected override ICollectionResponse GetAllList()
        {
            return Manager.Exchanges.Info.AssetsMeta();
        }

        protected override ICollectionResponse GetSkipList(int skip)
        {
            return Manager.Exchanges.Info.AssetsMeta(skip);
        }

        protected override ICollectionResponse GetLimitList(int limit)
        {
            return Manager.Exchanges.Info.AssetsMeta(limit: limit);
        }

        protected override ICollectionResponse GetSkipAndLimitList(int skip, int limit)
        {
            return Manager.Exchanges.Info.AssetsMeta(skip, limit);
        }
    }
}