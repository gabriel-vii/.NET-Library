﻿using System;
using CryptoApisLibrary.DataTypes;
using CryptoApisLibrary.ResponseTypes.Blockchains;

namespace CryptoApisSnippets.Samples.Blockchains
{
  partial class BlockchainSnippets
  {
    public void GetBlockHashDash()
    {
      var blockHash = "00000000000000000435d5c48d2c8dd4ca84c4f10a5b6e5a9cd6c81215dbe589";

      var manager = new CryptoManager(ApiKey);
      var response = manager.Blockchains.Info.GetBlockHash<GetBtcHashInfoResponse>(
        NetworkCoin.DashMainNet, blockHash);

      Console.WriteLine(string.IsNullOrEmpty(response.ErrorMessage)
        ? "GetBlockHashDash executed successfully, " +
          $"difficulty is {response.HashInfo.Difficulty} now"
        : $"GetBlockHashDash error: {response.ErrorMessage}");
    }
  }
}