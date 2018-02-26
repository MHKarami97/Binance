﻿using System;
using Binance.Client;
using Binance.WebSocket;
using Xunit;

namespace Binance.Tests.WebSocket
{
    public class DepthWebSocketClientTest
    {
        [Fact]
        public void Throws()
        {
            var client = new DepthWebSocketClient();

            Assert.Throws<ArgumentNullException>("symbol", () => client.Subscribe((string)null));
            Assert.Throws<ArgumentNullException>("symbol", () => client.Subscribe(string.Empty));
        }

        [Fact]
        public void SubscribeTwiceIgnored()
        {
            var symbol = Symbol.LTC_USDT;
            var client = new DepthWebSocketClient();

            client.Subscribe(symbol);
            client.Subscribe(symbol);
        }
    }
}
