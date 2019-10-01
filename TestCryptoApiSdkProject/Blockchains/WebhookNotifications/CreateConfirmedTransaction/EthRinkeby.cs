﻿using CryptoApisSdkLibrary.DataTypes;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptoApiSdkProject.Blockchains.WebhookNotifications.CreateConfirmedTransaction
{
    [TestClass]
    public class EthRinkeby : BaseEthSimilarCoin
    {
        protected override NetworkCoin NetworkCoin { get; } = NetworkCoin.EthRinkeby;
        protected override string TransactionHash { get; } = "0x87da27245076441baf7bcc6e93d328d80d11297a3a247a1ce3019168be3b7a36";
    }
}