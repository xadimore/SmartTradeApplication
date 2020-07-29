using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Web;
using SmartTrade.Data;
using SmartTrade.Data.ViewModel;
using SmartTrade.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SmartTrade.Pages
{
    public class IndexBase : ComponentBase
    {

        [Inject]
        public IPriceService PriceService { get; set; }
        public IEnumerable<Price> Prices { get; set; }
        public decimal CurrentPrice { get; set; }
        public decimal PreviousPrice { get; set; }
        public string DiffText { get; set; } = "over the last 7 days";
        public string OwnAmount { get; set; } = "none";

        public string MonthColor { get; set; } 
        public string DayColor { get; set; }
        public string AllTime { get; set; } 
        public string MonthsColor { get; set; } 
        public string Years { get; set; }

        public string AmountColor { get; set; } = "bg-secondary";
        public string AmountColor2 { get; set; }
        public string  AmountColor3 { get; set; }
        public string Zenith { get; set; } = "bg-warning";
        public string Wema { get; set; }
        public string Uba { get; set; }
        public string AirtelAfri { get; set; }
        public string Mtnn { get; set; }
        public string Guaranty { get; set; }

        public string ChangeColor { get; set; } = "ChangeColor";

        public string DefaultColor { get; set; } = "p2btn-forprice";

        
        public string StockPick { get; set; } = "ZENITHBANK";
        public int Days { get; set; } = 7;

        

        public decimal Amount { get; set; } = 5000;

       


        [Parameter]
        public decimal AmounttoBuy { get; set; }




        protected override async Task OnInitializedAsync()
        {
            Prices = PriceService.GetPrices().Where(c => c.Symbol == StockPick).OrderByDescending(c => c.Date).Take(Days);
            CurrentPrice = Prices.OrderBy(p => p.Date).Select(c => c.Close).Last();
            PreviousPrice = Prices.OrderBy(p => p.Date).Select(p => p.Close).Skip(1).FirstOrDefault();
            AmounttoBuy = Amount / CurrentPrice;
        }

        protected async Task ChangeData(int e)
        {
            
            Days = e;

            if( e == 7)
            {
                DiffText = "over the last seven days";
                DayColor = ChangeColor;
                MonthColor = null;
                MonthsColor = null;
                Years = null;
                AllTime = null;
            }

            else if( e == 30)
            {
                DiffText = "over the last 30 days";
                MonthColor = ChangeColor;
                DayColor = null;
               
                MonthsColor = null;
                Years = null;
                AllTime = null;
            }

            else if (e == 60)
            {
                DiffText = "over the last sixty days";
                MonthsColor = ChangeColor;
                DayColor = null;
                MonthColor = null;
                
                Years = null;
                AllTime = null;
            }

            else if (e == 80)
            {
                DiffText = "over the last one year";
                Years = ChangeColor;
                DayColor = null;
                MonthColor = null;
                MonthsColor = null;
               
                AllTime = null;
            }

            else if (e == 100)
            {
                DiffText = "over all time ";
                AllTime = ChangeColor;
                DayColor = null;
                MonthColor = null;
                MonthsColor = null;
                Years = null;
                
            }


            Prices = PriceService.GetPrices().Where(c => c.Symbol == StockPick).OrderByDescending(c => c.Date).Take(Days);
            CurrentPrice = Prices.OrderBy(p => p.Date).Select(c => c.Close).Last();
            PreviousPrice = Prices.OrderBy(p => p.Date).Select(p => p.Close).Skip(1).FirstOrDefault();
            AmounttoBuy = Amount / CurrentPrice;
        }


        protected async Task ChangeStock(string a)
        {
            StockPick = a;
            if(a == "ZENITHBANK")
            {
                Zenith = "bg-warning";
                Wema = null;
                Uba = null;
                AirtelAfri = null;
                Guaranty = null;
                Mtnn = null;
            }
            else if( a == "WEMABANK")
            {
                Zenith = null;
                Wema = "bg-warning";
                Uba = null;
                AirtelAfri = null;
                Guaranty = null;
                Mtnn = null;
            }

            else if (a == "MTNN")
            {
                Zenith = null;
                Wema = null;
                Uba = null;
                AirtelAfri = null;
                Guaranty = null;
                Mtnn = "bg-warning";
            }

            else if (a == "GUARANTY")
            {
                Zenith = null;
                Wema = null;
                Uba = null;
                AirtelAfri = null;
                Guaranty = "bg-warning";
                Mtnn = null;
            }

            else if (a == "AIRTELAFRI")
            {
                Zenith = null;
                Wema = null;
                Uba = null;
                AirtelAfri = "bg-warning";
                Guaranty = null;
                Mtnn = null;
            }

            else if (a == "UBA")
            {
                Zenith = null;
                Wema = null;
                Uba = "bg-warning";
                AirtelAfri = null;
                Guaranty = null;
                Mtnn = null;
            }
            Prices = PriceService.GetPrices().Where(c => c.Symbol == StockPick).OrderByDescending(c => c.Date).Take(Days);
            CurrentPrice = Prices.OrderBy(p => p.Date).Select(c => c.Close).Last();
            PreviousPrice = Prices.OrderBy(p => p.Date).Select(p => p.Close).Skip(1).FirstOrDefault();
            AmounttoBuy =  Amount / CurrentPrice;
        }


        protected  async Task ChangeAmount(decimal a)
        {
            
            if(a == 5000)
            {
                AmountColor = "bg-secondary";
                AmountColor2 = null;
                AmountColor3 = null;
                OwnAmount = "none";
                AmounttoBuy = a / CurrentPrice;
            }

            else if(a == 10000)
            {
                AmountColor = null;
                AmountColor2 = "bg-secondary";
                AmountColor3 = null;
                AmounttoBuy = a / CurrentPrice;
                OwnAmount = "none";

            }

            else
            {
                OwnAmount = "Display-block";
                AmountColor = null;
                AmountColor2 = null;
                AmountColor3 = "bg-secondary";
                AmounttoBuy = a / CurrentPrice;
            }
        }

        



        //public class ChartData
        //{
        //    public DateTime x { get; set; }
        //    public double high { get; set; }
        //    public double low { get; set; }
        //    public double open { get; set; }
        //    public double close { get; set; }
        //}


        //public List<ChartData> price = new List<ChartData>
        //{
        //   new ChartData {x = new DateTime(2019,02,01),close = 20, high = 21, low = 19, open = 19},
        //   new ChartData {x = new DateTime(2019,02,02),close = 10, high = 11, low = 8, open = 7},
        //   new ChartData {x = new DateTime(2019,02,03),close = 10, high = 21, low = 9, open = 8},
        //   new ChartData {x = new DateTime(2019,02,04),close = 30, high = 11, low = 9, open = 9},
        //   new ChartData {x = new DateTime(2019,02,02),close = 10, high = 51, low = 39, open = 9}
        //};

    }
}
