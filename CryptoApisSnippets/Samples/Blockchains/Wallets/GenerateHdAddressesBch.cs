﻿using System;
using CryptoApisLibrary.DataTypes;
using CryptoApisLibrary.ResponseTypes.Blockchains;

namespace CryptoApisSnippets.Samples.Blockchains
{
  partial class BlockchainSnippets
  {
    public void GenerateHdAddressesBch(string walletName)
    {
      var addressCount = 3;
      var encryptedPassword = "8a0690d2cd4fad1371090225217bb1425b3700210f51be6111eb225d5142ac32";

      var manager = new CryptoManager(ApiKey);
      var response = manager.Blockchains.Wallet.GenerateHdAddress<BchHdWalletInfoResponse>(
        NetworkCoin.BchMainNet, walletName, addressCount, encryptedPassword);

      Console.WriteLine(string.IsNullOrEmpty(response.ErrorMessage)
        ? "GenerateHdAddressesBch executed successfully, " +
          $"{response.Wallet.Addresses.Count} addresses of \"{response.Wallet.Name}\" wallet returned"
        : $"GenerateHdAddressesBch error: {response.ErrorMessage}");
    }
  }
}