
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


    public static class SeedAccounts
    {
        public static void SeedAllAccounts(AppDbContext db)
        {
             List<Account> Accounts = new List<Account>();
    


            Accounts.Add(new Account
            {                   
                AccountNumber = "2290000002",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "willsheff@email.com"),
                AccountName = "William's Savings",
                AccountType = AccountType.Savings,
            }) ; 

            
            Accounts.Add(new Account
            {
                AccountNumber = "2290000003",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "smartinmartin.Martin@aool.com"),
                AccountName = "Gregory's Checking",
                AccountType = AccountType.Checking,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000004",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "avelasco@yaho.com"),
                AccountName = "Allen's Checking",
                AccountType = AccountType.Checking,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000005",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "rwood@voyager.net"),
                AccountName = "Reagan's Checking",
                AccountType = AccountType.Checking,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000006",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "nelson.Kelly@aool.com"),
                AccountName = "Kelly's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000007",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "erynrice@aool.com"),
                AccountName = "Eryn's Checking",
                AccountType = AccountType.Checking,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000008",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "westj@pioneer.net"),
                AccountName = "Jake's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000010",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "jeff@ggmail.com"),
                AccountName = "Jeffrey's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000012",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "erynrice@aool.com"),
                AccountName = "Eryn's Checking 2",
                AccountType = AccountType.Checking,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000013",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "mackcloud@pimpdaddy.com"),
                AccountName = "Jennifer's IRA",
                AccountType = AccountType.IRA,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000014",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "ss34@ggmail.com"),
                AccountName = "Sarah's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000015",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "tanner@ggmail.com"),
                AccountName = "Jeremy's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000016",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "liz@ggmail.com"),
                AccountName = "Elizabeth's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000017",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "ra@aoo.com"),
                AccountName = "Allen's IRA",
                AccountType = AccountType.IRA,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000019",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "mclarence@aool.com"),
                AccountName = "Clarence's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000020",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "ss34@ggmail.com"),
                AccountName = "Sarah's Checking",
                AccountType = AccountType.Checking,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000021",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "cbaker@freezing.co.uk"),
                AccountName = "CBaker's Checking",
                AccountType = AccountType.Checking,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000022",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "cbaker@freezing.co.uk"),
                AccountName = "CBaker's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000023",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "cbaker@freezing.co.uk"),
                AccountName = "CBaker's IRA",
                AccountType = AccountType.IRA,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000025",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "chaley@thug.com"),
                AccountName = "C-dawg's Checking",
                AccountType = AccountType.Checking,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000026",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "chaley@thug.com"),
                AccountName = "C-dawg's Savings",
                AccountType = AccountType.Savings,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000027",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "mgar@aool.com"),
                AccountName = "Margaret's IRA",
                AccountType = AccountType.IRA,
            }) ; 


            Accounts.Add(new Account
            {
                AccountNumber = "2290000028",
                AppUser = db.Users.FirstOrDefault(u => u.Email == "Dixon@aool.com"),
                AccountName = "Shan's Checking",
                AccountType = AccountType.Checking,
            }) ; 

            //create a counter and flag to help with debugging
            int intAccountID = 0;
            String strAccountCustomer = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (Account seedAccount in Accounts)
                {
                    //updates the counters to get info on where the problem is
                    intAccountID = (int)seedAccount.AccountID;
                    strAccountCustomer = seedAccount.AppUser.Email;

                    //try to find the artistRating in the database based on whether there already exists and artist review with
                    //the same artist name and the same appuser's email 
                    Account dbAccount = db.Accounts.FirstOrDefault(c => (c.AppUser.Email == seedAccount.AppUser.Email));

                    //if the artistRating isn't in the database, dbArtistRating will be null
                    if (dbAccount == null)
                    {
                        //add the ArtistRating to the database
                        db.Accounts.Add(seedAccount);
                        db.SaveChanges();
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                        //this isn't really needed for artistRating because it only has one field
                        //but you will need it to re-set seeded data with more fields
                        


  
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
                msg.Append(strAccountCustomer);
                msg.Append(" Account (AccountID = ");
                msg.Append(intAccountID);
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
