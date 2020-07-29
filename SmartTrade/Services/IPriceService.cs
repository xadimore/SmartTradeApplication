using SmartTrade.Data;
using SmartTrade.Data.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartTrade.Services
{
    public interface IPriceService
    {



        IEnumerable<Price> GetPrices();

       
       

      
    }
}
