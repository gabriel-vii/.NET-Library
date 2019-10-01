﻿using CryptoApisSdkLibrary.DataTypes;
using CryptoApisSdkLibrary.ResponseTypes.Blockchains;
using System;

namespace CryptoApiSnippets.Samples.Blockchains
{
  partial class BlockchainSnippets
  {
    public string CreateAddressLtc()
    {
      var url = "http://www.mocky.io/v2/5b0d4b5f3100006e009d55f5";
      var address = "1Eeu3eC2b35LWtjXeRMJMSfrDnfDEjNwW6";

      var manager = new CryptoManager(ApiKey);
      var response = manager.Blockchains.WebhookNotification.CreateAddress<CreateBtcAddressWebHookResponse>(
        NetworkCoin.LtcMainNet, url, address);

      Console.WriteLine(string.IsNullOrEmpty(response.ErrorMessage)
        ? "CreateAddressLtc executed successfully, HookId is \"" +
          $"{response.Payload.Id}\""
        : $"CreateAddressLtc error: {response.ErrorMessage}");

      return response.Payload.Id;
    }
  }
}