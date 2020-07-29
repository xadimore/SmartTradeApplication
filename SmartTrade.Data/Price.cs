using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTrade.Data
{
    public class Price
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        public decimal Change { get; set; }
        public long Trades { get; set; }
        public long Volume { get; set; }
        public decimal Value { get; set; }

        public DateTime Date { get; set; }
    }
}
