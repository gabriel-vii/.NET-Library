﻿using CryptoApisLibrary.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CryptoApisLibrary.Tests.Blockchains.Transactions.GetInfoByBlockHeightAndTransactionIndex
{
    [TestClass]
    public class EthMain : BaseEthSimilarCoin
    {
        protected override NetworkCoin NetworkCoin { get; } = NetworkCoin.EthMainNet;
        protected override int BlockHeight { get; } = Features.CorrectBlockHeight.EthMainNet;
        protected override int TransactionIndex { get; } = 79;
    }
}