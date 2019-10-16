﻿using CryptoApisSdkLibrary.DataTypes;
using CryptoApisSdkLibrary.ResponseTypes.Blockchains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptoApiSdk.Blockchains.Info.GetBlockHeight
{
    [TestClass]
    public abstract class BaseEthSimilarCoin : BaseTest
    {
        [TestMethod]
        public void GeneralTest()
        {
            var response = Manager.Blockchains.Info.GetBlockHeight<GetEthHashInfoResponse>(NetworkCoin, BlockHeight);

            AssertNullErrorMessage(response);
            Assert.AreEqual(BlockHeight, response.HashInfo.Height, $"'{nameof(BlockHeight)}' is wrong");
        }

        [TestMethod]
        public void IncorrectedBlock()
        {
            var blockHeight = -123;
            var response = Manager.Blockchains.Info.GetBlockHeight<GetEthHashInfoResponse>(NetworkCoin, blockHeight);

            AssertErrorMessage(response, "Block not found");
        }

        protected abstract NetworkCoin NetworkCoin { get; }
        protected abstract int BlockHeight { get; }
    }
}