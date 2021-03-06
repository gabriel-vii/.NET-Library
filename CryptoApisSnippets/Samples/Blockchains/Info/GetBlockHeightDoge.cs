﻿using System;
using CryptoApisLibrary.DataTypes;
using CryptoApisLibrary.ResponseTypes.Blockchains;

namespace CryptoApisSnippets.Samples.Blockchains
{
  partial class BlockchainSnippets
  {
    public void GetBlockHeightDoge()
    {
      var blockHeight = 5;

      var manager = new CryptoManager(ApiKey);
      var response = manager.Blockchains.Info.GetBlockHeight<GetBtcHashInfoResponse>(
        NetworkCoin.DogeMainNet, blockHeight);

      Console.WriteLine(string.IsNullOrEmpty(response.ErrorMessage)
        ? "GetBlockHeightDoge executed successfully, " +
          $"difficulty is {response.HashInfo.Difficulty} now"
        : $"GetBlockHeightDoge error: {response.ErrorMessage}");
    }
  }
}