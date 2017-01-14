using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessTier
{
    public class Stock
    {
        public int id { get; set; }
        public string symbol { get; set; }
        public string name { get; set; }
        public int ipoYear { get; set; }
        public string sector { get; set; }
        public string industry { get; set; }
        public double currentPrice { get; set; }

        public Stock(int id,string symbol, string name, int ipoYear, string sector, string industry)
        {
            this.id = id;
            this.symbol = symbol;
            this.name = name;
            this.ipoYear = ipoYear;
            this.sector = sector;
            this.industry = industry;
            this.currentPrice = 50;
        }
        //public User(string symbol, string name)
        //{
        //    this.symbol = symbol;
        //    this.name = name;

        //}


    }
}                                                                                                                                                                                                                                                                                                     