using Microsoft.AspNetCore.Components;
using SmartTrade.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace SmartTrade.Services
{
    public class ApiPriceHistory : IPriceHistory
    {
        private readonly HttpClient httpClient;

        public ApiPriceHistory(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<IEnumerable<PriceHistory>> GetAllPrice()
        {
            return await httpClient.GetJsonAsync<PriceHistory[]>("api/sheets/05abdb05-642d-426a-a9c6-d385fad35598");
        }
    }
}
