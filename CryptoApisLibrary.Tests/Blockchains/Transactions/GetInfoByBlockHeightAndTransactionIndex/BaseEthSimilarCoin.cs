﻿using System;
using CryptoApisLibrary.DataTypes;
using CryptoApisLibrary.ResponseTypes.Blockchains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace CryptoApisLibrary.Tests.Blockchains.Transactions.GetInfoByBlockHeightAndTransactionIndex
{
    [TestClass]
    public abstract class BaseEthSimilarCoin : BaseTest
    {
        [TestMethod]
        public void GeneralTest()
        {
            var response = Manager.Blockchains.Transaction.GetInfo<EthTransactionInfoResponse>(
                NetworkCoin, BlockHeight, TransactionIndex);

            AssertNullErrorMessage(response);
            Assert.IsFalse(string.IsNullOrEmpty(response.Payload.TransactionHash),
                $"'{nameof(response.Payload.TransactionHash)}' must not be null");
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "A BlockHeight of null was inappropriately allowed.")]
        public void InvalidBlockHash()
        {
            var blockHeight = -6530876;
            Manager.Blockchains.Transaction.GetInfo<EthTransactionInfoResponse>(NetworkCoin, blockHeight, TransactionIndex);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException), "A TransactionIndex of null was inappropriately allowed.")]
        public void InvalidTransactionIndex()
        {
            var transactionIndex = -79;
            Manager.Blockchains.Transaction.GetInfo<EthTransactionInfoResponse>(NetworkCoin, BlockHeight, transactionIndex);
        }

        protected abstract NetworkCoin NetworkCoin { get; }
        protected abstract int BlockHeight { get; }
        protected abstract int TransactionIndex { get; }
    }
}