﻿using System;
using System.Collections.Generic;
using CryptoApisLibrary.DataTypes;
using CryptoApisLibrary.ResponseTypes.Blockchains;

namespace CryptoApisSnippets.Samples.Blockchains
{
  partial class BlockchainSnippets
  {
    public void NewHdTransactionBtc()
    {
      var wallet = "demohdwallet";
      var password = "8a0690d2cd4fad1371090225217bb1425b3700210f51be6111eb225d5142ac32";

      var  inputs = new List<TransactionAddress>();
      IEnumerable<TransactionAddress> outputs = new[]
      {
        new TransactionAddress("mn6GtNFRPwXtW7xJqH8Afck7FbVoRi6NF1", 0.004),
      };
      var fee = new Fee(0.00023141);

      var manager = new CryptoManager(ApiKey);
      var response = manager.Blockchains.Transaction.NewHdTransaction<NewBtcTransactionResponse>(
        NetworkCoin.BtcMainNet, wallet, password, inputs, outputs, fee);

      Console.WriteLine(string.IsNullOrEmpty(response.ErrorMessage)
        ? "NewHdTransactionBtc executed successfully, " +
          $"txid is \"{response.Payload.Txid}\""
        : $"NewHdTransactionBtc error: {response.ErrorMessage}");
    }
  }
}