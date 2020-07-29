using Microsoft.AspNetCore.Components;
using SmartTrade.Data;
using SmartTrade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartTrade.Pages
{
    public class CounterBase : ComponentBase
    {
        [Inject]
        public IPriceHistory PriceHistoryServices { get; set; }

        public IEnumerable<PriceHistory> PricesX { get; set; }








        protected override async Task OnInitializedAsync()
        {
            PricesX = (await PriceHistoryServices.GetAllPrice()).ToList();
            
        }




    }
}
