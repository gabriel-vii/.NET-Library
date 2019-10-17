﻿using System;
using CryptoApisLibrary.DataTypes;
using CryptoApisLibrary.ResponseTypes.Blockchains;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestCryptoApis.Blockchains.WebhookNotifications.DeleteHook
{
    [TestClass]
    public abstract class BaseEthSimilarCoin : BaseTest
    {
        [TestMethod]
        public void GeneralTest()
        {
            if (!IsAdditionalPackagePlan)
                return;

            var response = Manager.Blockchains.WebhookNotification.GetHooks<GetEthHooksResponse>(NetworkCoin);
            AssertNullErrorMessage(response);

            foreach (var hook in response.Hooks)
            {
                var deleteResponse = Manager.Blockchains.WebhookNotification.Delete<DeleteWebhookResponse>(NetworkCoin, hook.Id);
                AssertNullErrorMessage(deleteResponse);
                Assert.IsFalse(string.IsNullOrEmpty(deleteResponse.Payload.Message),
                    $"'{nameof(deleteResponse.Payload.Message)}' must not be null");
                Assert.AreEqual($"Webhook with id: {hook.Id} was successfully deleted!", deleteResponse.Payload.Message);
            }

            var secondResponse = Manager.Blockchains.WebhookNotification.GetHooks<GetEthHooksResponse>(NetworkCoin);
            AssertNullErrorMessage(secondResponse);
            AssertEmptyCollection(nameof(secondResponse.Hooks), secondResponse.Hooks);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentNullException), "A HookId of null was inappropriately allowed.")]
        public void DeleteNullHookId()
        {
            string hookId = null;
            Manager.Blockchains.WebhookNotification.Delete<DeleteWebhookResponse>(NetworkCoin, hookId);
        }

        [TestMethod]
        public void DeleteInvalidHookId()
        {
            var hookId = "qw'e";
            var response = Manager.Blockchains.WebhookNotification.Delete<DeleteWebhookResponse>(NetworkCoin, hookId);

            AssertErrorMessage(response, IsAdditionalPackagePlan
                ? $"Could not delete webhook with id: {hookId}"
                : "This endpoint has not been enabled for your package plan. Please contact us if you need this or upgrade your plan.");
        }

        protected abstract NetworkCoin NetworkCoin { get; }
    }
}