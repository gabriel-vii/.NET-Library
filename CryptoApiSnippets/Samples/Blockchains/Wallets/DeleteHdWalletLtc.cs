﻿using CryptoApisSdkLibrary.DataTypes;
using CryptoApisSdkLibrary.ResponseTypes.Blockchains;
using System;

namespace CryptoApiSnippets.Samples.Blockchains
{
  partial class BlockchainSnippets
  {
    public void DeleteHdWalletLtc(string walletName)
    {
      var manager = new CryptoManager(ApiKey);
      var response = manager.Blockchains.Wallet.DeleteWallet<DeleteWalletResponse>(
        NetworkCoin.LtcMainNet, walletName);

      Console.WriteLine(string.IsNullOrEmpty(response.ErrorMessage)
        ? "DeleteHdWalletLtc executed successfully, " +
          $"\"{response.Payload.Message}\" status was returned"
        : $"DeleteHdWalletLtc error: {response.ErrorMessage}");
    }
  }
}