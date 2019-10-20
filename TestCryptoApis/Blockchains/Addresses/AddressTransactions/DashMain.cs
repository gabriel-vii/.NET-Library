﻿using CryptoApisLibrary.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptoApis.Blockchains.Addresses.AddressTransactions
{
    [TestClass]
    public class DashMain : BaseBtcSimilarCoin
    {
        protected override string Address { get; } = Features.CorrectAddress.DashMainNet;
        protected override NetworkCoin NetworkCoin { get; } = NetworkCoin.DashMainNet;
    }
}