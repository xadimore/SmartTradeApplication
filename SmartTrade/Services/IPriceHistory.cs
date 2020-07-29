using SmartTrade.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartTrade.Services
{
    public interface IPriceHistory
    {
        Task<IEnumerable<PriceHistory>> GetAllPrice();
    }
}
