﻿using CryptoApisSdkLibrary.DataTypes;
using CryptoApisSdkLibrary.ResponseTypes.Blockchains;
using System;

namespace CryptoApiSnippets.Samples.Blockchains
{
  partial class BlockchainSnippets
  {
    public void GetHdWalletBch(string walletName)
    {
      var manager = new CryptoManager(ApiKey);
      var response = manager.Blockchains.Wallet.GetHdWalletInfo<HdWalletInfoResponse>(
        NetworkCoin.BchMainNet, walletName);

      Console.WriteLine(string.IsNullOrEmpty(response.ErrorMessage)
        ? "GetHdWalletBch executed successfully, " +
          $"{response.Wallet.Addresses.Count} addresses of \"" +
          $"{response.Wallet.Name}\" wallet returned"
        : $"GetHdWalletBch error: {response.ErrorMessage}");
    }
  }
}