﻿using CryptoApisLibrary.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptoApis.Blockchains.Addresses.AddressTransactions
{
    [TestClass]
    public class DashTest : BaseBtcSimilarCoin
    {
        protected override string Address { get; } = Features.CorrectAddress.DashTestNet;
        protected override NetworkCoin NetworkCoin { get; } = NetworkCoin.DashTestNet;
    }
}