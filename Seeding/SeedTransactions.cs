
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

    public static class SeedTransactions
    {
        public static void SeedAllTransactions(AppDbContext db)
        {
            List<Transaction> AllTransactions = new List<Transaction>();
    

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 1,
                User = "cbaker@freezing.co.uk",
                TransactionType = TransactionType.Deposit,
                ToAccount = "2290000021.0",
                FromAccount = "nan",
                Amount = 4000,
                DisputeDate = new DateTime(2022-01-15 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "nan"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 2,
                User = "cbaker@freezing.co.uk",
                TransactionType = TransactionType.Deposit,
                ToAccount = "2290000022.0",
                FromAccount = "nan",
                Amount = 2200,
                DisputeDate = new DateTime(2022-03-05 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "This transaction went so well! I will be using this bank again for sure!!"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 3,
                User = "cbaker@freezing.co.uk",
                TransactionType = TransactionType.Deposit,
                ToAccount = "2290000022.0",
                FromAccount = "nan",
                Amount = 6000,
                DisputeDate = new DateTime(2022-03-09 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "nan"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 4,
                User = "cbaker@freezing.co.uk",
                TransactionType = TransactionType.Transfer,
                ToAccount = "2290000021.0",
                FromAccount = "2290000022.0",
                Amount = 1200,
                DisputeDate = new DateTime(2022-04-14 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "Jacob Foster has a GPA of 1.92. LOL"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 5,
                User = "cbaker@freezing.co.uk",
                TransactionType = TransactionType.Withdraw,
                ToAccount = "nan",
                FromAccount = "2290000022.0",
                Amount = 352,
                DisputeDate = new DateTime(2022-04-21 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "Longhorn Bank is my favorite bank! I couldn't dream of putting my money anywhere else."
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 6,
                User = "cbaker@freezing.co.uk",
                TransactionType = TransactionType.Deposit,
                ToAccount = "2290000023.0",
                FromAccount = "nan",
                Amount = 1500,
                DisputeDate = new DateTime(2022-03-08 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "nan"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 7,
                User = "cbaker@freezing.co.uk",
                TransactionType = TransactionType.Transfer,
                ToAccount = "2290000021.0",
                FromAccount = "2290000024.0",
                Amount = 3000,
                DisputeDate = new DateTime(2022-04-20 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "nan"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 8,
                User = "cbaker@freezing.co.uk",
                TransactionType = TransactionType.Withdraw,
                ToAccount = "nan",
                FromAccount = "2290000021.0",
                Amount = 578,
                DisputeDate = new DateTime(2022-04-19 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "K project snack expenses"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 9,
                User = "chaley@thug.com",
                TransactionType = TransactionType.Transfer,
                ToAccount = "2290000025.0",
                FromAccount = "2290000026.0",
                Amount = 52,
                DisputeDate = new DateTime(2022-04-29 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "nan"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 10,
                User = "ss34@ggmail.com",
                TransactionType = TransactionType.Withdraw,
                ToAccount = "nan",
                FromAccount = "2290000020.0",
                Amount = 4000,
                DisputeDate = new DateTime(2022-03-07 00:00:00 )                
                Approved = Approved.Yes,
                TransactionComments = "This is totally not fraudulent 0_o"
       }); 

      AllTransactions.Add(new Transaction()
      {
                TransactionID = 11,
                User = "liz@ggmail.com",
                TransactionType = TransactionType.Deposit,
                ToAccount = "2290000016.0",
                FromAccount = "nan",
                Amount = 6000,
                DisputeDate = new DateTime(2022-05-01 00:00:00 )                
                Approved = Approved.No,
                TransactionComments = "I got this money from my new business at the Blue Cat Lodge"
       }); 

            //create a counter and flag to help with debugging
            int intTransactionID = 0;

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the transactions
                foreach (Transaction seedTransaction in AllTransactions)
                {
                    //updates the counters to get info on where the problem is
                    intTransactionID = seedTransaction.TransactionID;

                    //try to find the transaction in the database
                    Transaction dbTransaction = db.Transactions.FirstOrDefault(c => c.TransactionName == seedTransaction.TransactionName);

                    //if the Transaction isn't in the database, dbTransaction will be null
                    if (dbTransaction == null)
                    {
                        //add the Transaction to the database
                        db.Transactions.Add(seedTransaction);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for Transaction because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        dbTransaction.TransactionFeatured = seedTransaction.TransactionFeatured;
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
                msg.Append(" Transaction (TransactionID = ");
                msg.Append(intTransactionID);
                msg.Append(")");

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }
  
