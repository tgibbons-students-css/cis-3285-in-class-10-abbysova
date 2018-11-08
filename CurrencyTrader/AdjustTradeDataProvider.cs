using System;
using System.Collections.Generic;
using System.IO;
using System.Net;

using CurrencyTrader.Contracts;

namespace CurrencyTrader
{
    public class AdjustTradeProvider : ITradeDataProvider
    {
        private readonly String url;

        ITradeDataProvider urlProvider;

        public AdjustTradeProvider(String url)
        {
            this.url = url;
            urlProvider = new UrlTradeDatatProvider();
        }

        public IEnumerable<string> GetTradeData()
        {
            IEnumerable<string> tradeText = urlProvider.getTradeData();
                List<string> newTradeText = new List<string>();

                   foreach(string line in tradeText)
                    {
                        newTradeText.Add(line.Replace("GBP", "EUR"));
                    }
                   return newtradeText;
                    }


    }
}


