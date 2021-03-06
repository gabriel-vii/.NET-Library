﻿using System;
using CryptoApisLibrary.DataTypes;

namespace CryptoApisSnippets.Samples.Exchanges
{
  partial class ExchangeSnippets
  {
    public void ExchangesSupportingPairs()
    {
      var asset1 = new Asset("5b1ea92e584bf50020130612");
      var asset2 = new Asset("5b755dacd5dd99000b3d92b2");

      var manager = new CryptoManager(ApiKey);
      var response = manager.Exchanges.Info.ExchangesSupportingPairs(
        asset1, asset2, skip: 0, limit: 10);

      Console.WriteLine(string.IsNullOrEmpty(response.ErrorMessage)
        ? "ExchangesSupportingPairs executed successfully, " +
          $"{response.Infos.Count} exchanges returned"
        : $"ExchangesSupportingPairs error: {response.ErrorMessage}");
    }
  }
}