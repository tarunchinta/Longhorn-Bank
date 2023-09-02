using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fa22_finalproject_32.DAL;
using fa22_finalproject_32.Models;
using Microsoft.AspNetCore.Mvc;

namespace fa22_finalproject_32.Seeding
{
    public static class SeedStockPortfolio
    {
        public static void SeedAllStockPortfolios(AppDbContext db)
        {

            Int32 intStockPortfoliosAdded = 0;
            String strPropertyAddress = "Begin";

            //Create a new list for all of the properties
            List<StockPortfolio> AllStockPortfolios = new List<StockPortfolio>();
            StockPortfolio sp1 = new StockPortfolio()

            {
                AccountNumber = "2290000001",
                AccountName = "Shan's Stock",
                CashBalance = 0.00m
            };
            sp1.AppUser = db.Users.FirstOrDefault(u => u.Email == "Dixon@aool.com");
            AllStockPortfolios.Add(sp1);

            StockPortfolio sp2 = new StockPortfolio()
            {
                AccountNumber = "2290000009",
                AccountName = "Michelle's Stock",
                CashBalance =  8888.88m
            };
            sp2.AppUser = db.Users.FirstOrDefault(u => u.Email == "mb@aool.com");
            AllStockPortfolios.Add(sp2);

            StockPortfolio sp3 = new StockPortfolio()
            {
                AccountNumber = "2290000011",
                AccountName = "Kelly's Stock",
                CashBalance = 420.00m
            };
            sp3.AppUser = db.Users.FirstOrDefault(u => u.Email == "nelson.Kelly@aool.com");
            AllStockPortfolios.Add(sp3);

            StockPortfolio sp4 = new StockPortfolio()
            {
                AccountNumber = "2290000018",
                AccountName = "John's Stock",
                CashBalance = 0.00m
            };
            sp4.AppUser = db.Users.FirstOrDefault(u => u.Email == "johnsmith187@aool.com");
            AllStockPortfolios.Add(sp4);

            StockPortfolio sp5 = new StockPortfolio()
            {
                AccountNumber = "2290000024",
                AccountName = "CBaker's Stock",
                CashBalance = 6900.00m
            };
            sp5.AppUser = db.Users.FirstOrDefault(u => u.Email == "cbaker@freezing.co.uk");
            AllStockPortfolios.Add(sp5);












            int intStockPortfolioID = 0;

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the Stocks
                foreach (StockPortfolio SeedStockPortfolio in AllStockPortfolios)
                {
                    //updates the counters to get info on where the problem is
                    intStockPortfolioID = SeedStockPortfolio.StockPortfolioID;

                    //try to find the Stock in the database
                    StockPortfolio dbStockPortfolio = db.StockPortfolios.FirstOrDefault(c => c.StockPortfolioID == SeedStockPortfolio.StockPortfolioID);

                    //if the Stock isn't in the database, dbStock will be null
                    if (dbStockPortfolio == null)
                    {
                        //add the Stock to the database
                        db.StockPortfolios.Add(SeedStockPortfolio);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for Stock because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbStockPortfolio.AccountNumber = SeedStockPortfolio.AccountNumber;
                        dbStockPortfolio.AccountName = SeedStockPortfolio.AccountName;
                        dbStockPortfolio.CashBalance = SeedStockPortfolio.CashBalance;
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
                msg.Append(intStockPortfolioID);
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