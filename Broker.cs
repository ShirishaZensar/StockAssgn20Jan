using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using StockMarketLib;

namespace StockClass
{
    class Broker
    {
        List<Stock> oStocks = new List<Stock> {
                        new Stock{ StockName="WIPRO",Quantity=10,StockPrice=4558.23 ,SType= "Equity"},
                        new Stock{ StockName="TATA MOTORS", Quantity=20, StockPrice=1458.58,SType= "Mutual Fund"},
                        new Stock{ StockName="ITC", Quantity=32,StockPrice=6358.24,SType= "Equity"},
                        new Stock{ StockName="INFOSYS", Quantity=40,StockPrice=715.36,SType= "Mutual Fund"},
                        new Stock{ StockName="BOSCH",  Quantity=100,StockPrice=4358.96,SType= "Equity"}
           };
        public void BuyStock()
        {   
            Console.WriteLine("************Details of Stock Market***********");
            foreach (var shares in oStocks)
            {
                Console.WriteLine("StockName : " + shares.StockName);
                Console.WriteLine("StockPrice : " + shares.StockPrice);
                Console.WriteLine("Quantity : " + shares.Quantity);
                Console.WriteLine("StockType : " + shares.SType + "\n");
            }
            Console.WriteLine("***********************************************\n");
        }
        public void ShowPortfolio()
        {
            Console.WriteLine("***************NetWorth of Stocks************");
            foreach (var divide in oStocks)
            {
                double mTotal = 0;
                    mTotal = (divide.StockPrice * divide.Quantity);
                Console.WriteLine($"NetWorth of {divide.StockName} : {mTotal}");
                
            }
            Console.WriteLine("***********************************************\n");
        }
        static void Main(string[] args)
        {
            Console.WriteLine("\n");
            Broker p = new Broker();
           /* Stock s = new Stock("Wip", 255.36, 6);
            Console.WriteLine(s.StockName);
            Console.WriteLine(s.StockPrice);
            Console.WriteLine(s.Quantity);*/
            p.BuyStock();
            p.ShowPortfolio();
        }
    }
}
