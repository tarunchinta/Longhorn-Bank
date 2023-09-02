using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using fa22_finalproject_32.DAL;
using fa22_finalproject_32.Models;
using Microsoft.AspNetCore.Mvc;

namespace fa22_finalproject_32.Seeding
{
    public static class SeedStockTransactions
    {
        public static void SeedAllStockTransactions(AppDbContext db)
        {
            //Create a list of AddUserModels
            List<StockTransaction> AllStockTransactions = new List<StockTransaction>();


            AllStockTransactions.Add(new StockTransaction()
            {

                    PortfolioOwner = "cbaker@freezing.co.uk",
                    StockType = "Purchase",
                    AssociatedCashBalanceAccount = "2290000024",
                    Pricepershare = 145.03m,
                    NumofShares = 10,
                    SelectedStock = "AAPL",
                    StockTransactionDate = new DateTime(4 / 1 / 2022)
                });
            AllStockTransactions.Add(new StockTransaction()
            {

                    PortfolioOwner = "cbaker@freezing.co.uk",
                    StockType = "Purchase",
                    AssociatedCashBalanceAccount = "2290000024",
                    Pricepershare = 321.36m,
                    NumofShares = 5,
                    SelectedStock = "DIA",
                    StockTransactionDate = new DateTime(4 / 3 / 2022)
                });
            AllStockTransactions.Add(new StockTransaction()
            {

                    PortfolioOwner = "cbaker@freezing.co.uk",
                    StockType = "Purchase",
                    AssociatedCashBalanceAccount = "2290000024",
                    Pricepershare = 18.10m,
                    NumofShares = 2,
                    SelectedStock = "FLCEX",
                    StockTransactionDate = new DateTime(4 / 28 / 2022)
                });
            int intStockTransactionID = 0;


            //String strPropertyAddress = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (StockTransaction StockTransactionToAdd in AllStockTransactions)
                {
                    //updates the counters to get info on where the problem is
                    intStockTransactionID = StockTransactionToAdd.StockTransactionID;
                    //strPropertyAddress = reviewToAdd.street;


                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's first + last name associated with it

            StockTransaction dbStockTransaction = db.StockTransaction.FirstOrDefault(rn => (rn.StockTransactionID == StockTransactionToAdd.StockTransactionID)
                                                               
                                                                                  );

                    //if the artistRating isn't in the database, dbArtistRating will be null
                    if (dbStockTransaction == null)
                    {
                        //add the ArtistRating to the database
                        db.StockTransaction.Add(StockTransactionToAdd);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields



                        dbStockTransaction.StockPortfolio = StockTransactionToAdd.StockPortfolio;
                        dbStockTransaction.PortfolioOwner= StockTransactionToAdd.PortfolioOwner;
                        dbStockTransaction.StockType = StockTransactionToAdd.StockType;
                        dbStockTransaction.AssociatedCashBalanceAccount = StockTransactionToAdd.AssociatedCashBalanceAccount;
                        dbStockTransaction.Pricepershare = StockTransactionToAdd.Pricepershare;
                        dbStockTransaction.NumofShares = StockTransactionToAdd.NumofShares;
                        dbStockTransaction.Stock = StockTransactionToAdd.Stock;
                        dbStockTransaction.StockTransactionDate = StockTransactionToAdd.StockTransactionDate;



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
                msg.Append(intStockTransactionID);


                throw new Exception(msg.ToString(), ex);
            }

        }
    }

}