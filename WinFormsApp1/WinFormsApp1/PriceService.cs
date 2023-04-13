using System;
using System.Collections.Generic;
using System.Text;

namespace WinFormsApp1
{
    enum Price{
        Size9_12 = 1,
        Size12_15 = 2,
        Size18_24 = 3
     }
    static class PriceService
    {
        static Dictionary<Price, decimal> Prices { get; set; }
        static PriceService()
        {
            Prices = new Dictionary<Price, decimal>();
            Prices.Add(Price.Size9_12, 10m);
            Prices.Add(Price.Size12_15, 15m);
            Prices.Add(Price.Size18_24, 20m);
        }
        public static decimal GetPrice(Price key, int count) => Prices[key] * count; 

    }
}
