﻿using CryptoApisSdkLibrary.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptoApiSdkProject.Blockchains.Wallets.DeleteWallet
{
    [TestClass]
    public class DogeMain : BaseBtcSimilarCoin
    {
        protected override NetworkCoin NetworkCoin { get; } = NetworkCoin.DogeMainNet;
    }
}