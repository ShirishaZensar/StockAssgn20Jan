using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StockMarketLib
{
   
    public class Stock
    {
        //Attributes
         int qt;
         string Name;
         double Price;

        public enum StockType
        {
            Equity,
            MutualFund
        };
        //Ctor
        public Stock()
        {

        }
        public Stock(string StockName, double SPrice)
        {
            Name = StockName;
            Price = SPrice;
        }
        public Stock(string StockName, double SPrice,int q)
        {
            Name = StockName;
            Price = SPrice;
            this.qt = 100;
        }
        //Properties
        public string StockName { get; set; }
        public double StockPrice { get; set; }
        public int Quantity { get; set; } = 100;
        public string SType { get; set; }

    }
}
