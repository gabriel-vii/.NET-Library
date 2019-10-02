﻿using CryptoApisSdkLibrary.DataTypes;
using CryptoApisSdkLibrary.ResponseTypes.Blockchains;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace TestCryptoApiSdkProject.Blockchains.Transactions.GetInfoByTransactionId
{
    [TestClass]
    public abstract class BaseBtcSimilarCoin : BaseTest
    {
        [TestMethod]
        public void GeneralTest()
        {
            var response = Manager.Blockchains.Transaction.GetInfo<BtcTransactionInfoResponse>(NetworkCoin, TransactionId);

            Assert.IsNotNull(response);
            Assert.IsTrue(string.IsNullOrEmpty(response.ErrorMessage));
            Assert.AreEqual(TransactionId, response.Transaction.Id);
        }

        [TestMethod]
        public void InvalidBlockHash()
        {
            var response = Manager.Blockchains.Transaction.GetInfo<BtcTransactionInfoResponse>(NetworkCoin, transactionId: "qwe");

            Assert.IsNotNull(response);
            Assert.IsFalse(string.IsNullOrEmpty(response.ErrorMessage));
            Assert.AreEqual("Transaction not found", response.ErrorMessage);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "A TransactionId of null was inappropriately allowed.")]
        public void NullTransactionId()
        {
            Manager.Blockchains.Transaction.GetInfo<BtcTransactionInfoResponse>(NetworkCoin, transactionId: null);
        }

        protected abstract NetworkCoin NetworkCoin { get; }
        protected abstract string TransactionId { get; }
    }
}