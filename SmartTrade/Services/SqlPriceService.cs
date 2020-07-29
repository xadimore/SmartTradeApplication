using Microsoft.AspNetCore.Components;
using SmartTrade.Data;
using SmartTrade.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;

namespace SmartTrade.Services
{
    public class SqlPriceService : IPriceService
    {

       

        private readonly DatabaseConnection db;
        

        public SqlPriceService(DatabaseConnection db)
        {
            this.db = db;
        }

       

        public IEnumerable<Price> GetPrices()
        {
            return db.Prices.ToList();
        }

        
    }
}
