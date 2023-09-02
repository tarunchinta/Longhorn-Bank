using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;
using fa22_finalproject_32.DAL;
using fa22_finalproject_32.Models;
using fa22_finalproject_32.Utilities;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace fa22_finalproject_32.Seeding
{

    public static class SeedDisputes
    {
        public static void SeedAllDisputes(AppDbContext db)
        {
            //Create a list of AddUserModels
            List<Dispute> AllDisputes = new List<Dispute>();


            Dispute d2 = new Dispute()
            {

                    //populate the user properties that are from the 
                    //IdentityUser base class
                    Customer = "t.jacobs@longhornbank.neet",
                    CorrectAmount = 300.00m,
                    DisputeDescription = "I don’t remember buying so many snacks",
                    Status = Status.submitted

               
            };
            d2.Transaction = db.Transactions.FirstOrDefault(u => u.TransactionID == 8);

            AllDisputes.Add(d2);
            Dispute d3 = new Dispute()
            {
                    Customer = "ss34@ggmail.com",
                    CorrectAmount = 0.00m,
                    DisputeDescription = "You rapscallions are trying to steal my money!!!",
                    Status = Status.submitted

            };
            d3.Transaction = db.Transactions.FirstOrDefault(u => u.TransactionID == 10);
            AllDisputes.Add(d3);

            int intDisputeID = 0;
            //String strPropertyAddress = "Start";

            //we are now going to add the data to the database
            //this could cause errors, so we need to put this code
            //into a Try/Catch block
            try
            {
                //loop through each of the artistRatings
                foreach (Dispute seedDispute in AllDisputes)
                {
                    //updates the counters to get info on where the problem is
                    intDisputeID = seedDispute.DisputeID;

                    Dispute dbDispute = db.Disputes.FirstOrDefault(rn => (rn.DisputeID == seedDispute.DisputeID)
                                                                                  );

                    if (dbDispute == null)
                    {
                                            db.Disputes.Add(seedDispute);
                        db.SaveChanges();

                        intDisputeID += 1;
                    }
                    else //the record is in the database
                    {
                        //update all the fields
                  
                        dbDispute.Customer = seedDispute.Customer;
                        dbDispute.CorrectAmount = seedDispute.CorrectAmount;
                        dbDispute.DisputeDescription = seedDispute.DisputeDescription;
                        dbDispute.Status = seedDispute.Status;



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
                msg.Append(intDisputeID);

                //have this method throw the exception to the calling method
                //this code wraps the exception from the database with the 
                //custom message we built above. The original error from the
                //database becomes the InnerException
                throw new Exception(msg.ToString(), ex);
            }

        }
    }

}