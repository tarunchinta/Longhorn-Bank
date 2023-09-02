
using fa22_finalproject_32.DAL;
using fa22_finalproject_32.Models;
using fa22_finalproject_32.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace fa22_finalproject_32.Seeding
{

    public static class SeedStocks
    {
        public static void SeedAllStocks(AppDbContext db)
        {
            List<Stock> AllStocks = new List<Stock>();

            AllStocks.Add(new Stock()
            {
                    StockTicker = "GOOG",
                    StockName = "Alphabet Inc.",
                    Price = 87.07m,
                StockTypeName = StockTypeName.Ordinary

            });
            AllStocks.Add(new Stock()
            {
                    StockTicker = "AAPL",
                    StockName = "Apple Inc.",
                    Price = 145.03m,
                StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "AMZN",
                    StockName = "Amazon.com Inc.",
                    Price = 92.12m,
                StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "LUV",
                    StockName = "Southwest Airlines",
                    Price = 36.5m,
                StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "TXN",
                    StockName = "Texas Instruments",
                    Price = 158.49m,
                StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "HSY",
                    StockName = "The Hershey Company",
                    Price = 235.11m,
                StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "V",
                    StockName = "Visa Inc.",
                    Price = 200.95m,
                StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "NKE",
                    StockName = "Nike",
                    Price = 90.3m,
                    StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "VWO",
                    StockName = "Vanguard Emerging Markets ETF",
                    Price = 35.77m,
                    StockTypeName = StockTypeName.etf

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "CORN",
                    StockName = "Corn",
                    Price = 27.35m,
                    StockTypeName = StockTypeName.future_share

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "FXAIX",
                    StockName = "Fidelity 500 Index Fund",
                    Price = 133.88m,
                    StockTypeName = StockTypeName.mutual_fund

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "F",
                    StockName = "Ford Motor Company",
                    Price = 13.06m,
                    StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "BAC",
                    StockName = "Bank of America Corporation",
                    Price = 36.09m,
                    StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "VNQ",
                    StockName = "Vanguard REIT ETF",
                    Price = 80.67m,
                    StockTypeName = StockTypeName.etf

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "NSDQ",
                    StockName = "Nasdaq Index Fund",
                    Price = 10524.8m,
                    StockTypeName = StockTypeName.index_fund

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "KMX",
                    StockName = "CarMax, Inc.",
                    Price = 62.36m,
                    StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "DIA",
                    StockName = "Dow Jones Industrial Average Index Fund",
                    Price = 321.36m,
                    StockTypeName = StockTypeName.index_fund

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "SPY",
                    StockName = "S&P 500 Index Fund",
                    Price = 374.87m,
                    StockTypeName = StockTypeName.index_fund

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "BEN",
                    StockName = "Franklin Resources, Inc.",
                    Price = 22.56m,
                    StockTypeName = StockTypeName.Ordinary

            });

            AllStocks.Add(new Stock()
            {
                    StockTicker = "FLCEX",
                    StockName = "Fidelity Large Cap Core Enhanced Index Fund",
                    Price = 18.1m,
                    StockTypeName = StockTypeName.mutual_fund

            });

            //create a counter and flag to help with debugging
            int intStockID = 0;

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Stocks
                foreach (Stock seedStock in AllStocks)
                {
                    //updates the counters to get info on where the problem is
                    intStockID = seedStock.StockID;

                    //try to find the Stock in the database
                    Stock dbStock = db.Stocks.FirstOrDefault(c => c.StockID == seedStock.StockID);

                    //if the Stock isn't in the database, dbStock will be null
                    if (dbStock == null)
                    {
                        //add the Stock to the database
                        db.Stocks.Add(seedStock);
                        db.SaveChanges();

                        intStockID += 1;
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for Stock because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbStock.StockTicker = seedStock.StockTicker;
                        dbStock.StockName = seedStock.StockName;
                        dbStock.Price = seedStock.Price;
                        dbStock.StockTypeName = seedStock.StockTypeName;
                        //you would add other fields here
                        db.SaveChanges();
                    }

                }
            }
            catch (Exception ex) //something about adding to the database caused a problem
            {
                //create a new instance of the string builder to make building out 
                //our message neater - we don't want a REALLY long line of code for this
                //so we break it up into several lines
                StringBuilder msg = new StringBuilder();

                msg.Append("There was an error adding the ");
                msg.Append(" Stock (StockID = ");
                msg.Append(intStockID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }
  
        }
    }
        
}
