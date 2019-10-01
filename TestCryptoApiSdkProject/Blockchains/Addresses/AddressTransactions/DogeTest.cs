﻿using CryptoApisSdkLibrary.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptoApiSdkProject.Blockchains.Addresses.AddressTransactions
{
    [TestClass]
    public class DogeTest : BaseBtcSimilarCoin
    {
        protected override string Address { get; } = "nsXYgWCuBVSYxD1rWz543EFkfxcPV9PC2y";
        protected override NetworkCoin NetworkCoin { get; } = NetworkCoin.DogeTestNet;
    }
}