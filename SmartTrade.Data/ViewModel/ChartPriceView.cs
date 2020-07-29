using System;
using System.Collections.Generic;
using System.Text;

namespace SmartTrade.Data.ViewModel
{
    public class ChartPriceView
    {
        public int Id { get; set; }
        public string Symbol { get; set; }
        public decimal Open { get; set; }
        public decimal High { get; set; }
        public decimal Low { get; set; }
        public decimal Close { get; set; }
        
        public DateTime Date { get; set; }
    }
}
