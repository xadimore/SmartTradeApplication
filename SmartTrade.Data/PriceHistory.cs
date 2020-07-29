using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SmartTrade.Data
{
    public class PriceHistory
    {
        public int Id { get; set; }



        
        
        public DateTime Date { get; set; }
        public decimal ClosingPrice { get; set; }
        public decimal OpeningPrice { get; set; }
        public string Symbol { get; set; }
    }
}
