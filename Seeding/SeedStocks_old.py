# -*- coding: utf-8 -*-
"""Copy of Copy of SeedFile.ipynb

Automatically generated by Colaboratory.

Original file is located at
    https://colab.research.google.com/drive/14PgT7QEUPh-C_8st4TpJs2nNx5cYXL9J
"""

import pandas as pd
# Sets the raw url variable to a google drive link
google_drive_url = "https://docs.google.com/spreadsheets/d/1E_wNkaGU22AwCGc4p-bo_YujfPT1pvNq/edit?usp=share_link&ouid=111659708370824727716&rtpof=true&sd=true"
# Changes the google drive URL to 
raw_url = 'https://drive.google.com/uc?id=' + google_drive_url.split('/')[-2]

# Declare the sheet names that you are wanting to pull data from
sheet_names = ["Customers",
               "Employees",
               "Accounts",
               "StockPortfolio",
               "Stocks",
               "Transactions",
               "StockTransactions",
               "Disputes",
              ]

data = pd.read_excel(raw_url, sheet_name = sheet_names)

PROJECT_NAME = "fa22_finalproject_32"

def using_statements():
  """Returns the using statements and adds the opening brackets necessary for"""
  
  
  
  return f"""
using {PROJECT_NAME}.DAL;
using {PROJECT_NAME}.Models;
using {PROJECT_NAME}.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;

namespace {PROJECT_NAME}.Seeding
{{
"""

# Instantiate a string to hold the customers seeding text
stocks_string = ""

# Adds the using statements necessary for the C# code to work
stocks_string += using_statements()

# Adds necessary C# code for adding users, based off of HW3's seeding code.
# No variables are needed so there is no need to make it an f-string
stocks_string += """
    public static class SeedStocks
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AllStocks
            List AllStocks = new List();

"""

# Iterate through all customers and add the values to the string
for stock in data["Stocks"].to_dict(orient="records"):
  # For each customer in the data, create new lines of code that specify the User's properties
  stocks_string += f"""
            AllStocks.Add(new List()
            {{
                AllStocks = new Stocks()
                {{
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    TickerSymbol = "{stock["TickerSymbol"]}",
                    StockName = "{stock["Name"]}",
                    StockPrice = "{stock["Price"]}",
                    StockType = "{stock["StockType"]}",
                }},
            }});
"""

print(stocks_string)

stocks_string += """
            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (Stock aum in AllStocks)
                {
                    errorFlag = aum.User.Email;
                    // Took Utilities.AddUser from Relational Data Demo -> this is "Utilities/AddUser.cs"
                    result = await Utilities.AddUser.AddUserWithRoleAsync(aum, userManager, context);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("There was a problem adding the user with email: " 
                    + errorFlag, ex);
            }

            return result;

        }
    }
}
"""

file = open("SeedStocks.cs", "w")
file.write(stocks_string)
file.close()