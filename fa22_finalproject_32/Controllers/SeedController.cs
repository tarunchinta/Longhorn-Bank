//pre-existing, might delete or needs lot of changing

using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using Microsoft.AspNetCore.Authorization;

using fa22_finalproject_32.Models;
using fa22_finalproject_32.DAL;

namespace fa22_finalproject_32.Controllers
{
    [Authorize("Admin")]
    public class SeedController : Controller

    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public SeedController(AppDbContext db, UserManager<AppUser> um, RoleManager<IdentityRole> rm)
        {
            _context = db;
            _userManager = um;
            _roleManager = rm;
        }

        public IActionResult Index()
        {
            return View();
        }
        public async Task<IActionResult> SeedRoles()
        {
            try
            {
                //call the method to seed the roles
                await Seeding.SeedRoles.AddAllRoles(_roleManager);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }
        public async Task<IActionResult> SeedUsers()
        {
            try
            {
                //call the method to seed the users
                await Seeding.SeedUsers.SeedAllUsers(_userManager, _context);

            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception
                errorList.Add(ex.InnerException.Message);

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                return View("Error", errorList);
            }

            //this is the happy path - seeding worked!
            return View("Confirm");
        }
        public IActionResult SeedCategories()
        {
            try
            {
                //call the SeedAllGenres method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                //Seeding.SeedCustomers(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this category.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);

                    //Add additional inner exception messages, if there are any
                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }
                }


                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }


        public IActionResult SeedDisputes()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block
            try
            {
                //call the SeedBooks method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedDisputes.SeedAllDisputes(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this property.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                //Add additional inner exception messages, if there are any
                if (ex.InnerException != null && ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }


        public IActionResult SeedStockPortfolio()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block
            try
            {
                //call the SeedBooks method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedStockPortfolio.SeedAllStockPortfolios(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this property.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }

        public IActionResult SeedStocks()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block
            try
            {
                //call the SeedBooks method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedStocks.SeedAllStocks(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this property.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }
        public IActionResult SeedStockTransactions()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block
            try
            {
                //call the SeedBooks method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedStockTransactions.SeedAllStockTransactions(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this property.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");
        }
        public IActionResult SeedTransactions()
        {
            //this code may throw an exception, so we need to be in a Try/Catch block
            try
            {
                //call the SeedBooks method from your Seeding folder
                //you will need to pass in the instance of AppDbContext
                //that you set in the constructor
                Seeding.SeedTransactions.SeedAllTransactions(_context);
            }
            catch (Exception ex)
            {
                //add the error messages to a list of strings
                List<String> errorList = new List<String>();

                errorList.Add("There was a problem adding this property.");

                //Add the outer message
                errorList.Add(ex.Message);

                //Add the message from the inner exception, if there is one
                if (ex.InnerException != null)
                {
                    errorList.Add(ex.InnerException.Message);
                }

                //Add additional inner exception messages, if there are any
                if (ex.InnerException.InnerException != null)
                {
                    errorList.Add(ex.InnerException.InnerException.Message);
                }

                //return the user to the error view
                return View("Error", errorList);
            }

            //everything is okay - send user to confirmation page
            return View("Confirm");

        }
            public IActionResult SeedAccounts()
            {
                //this code may throw an exception, so we need to be in a Try/Catch block
                try
                {
                    //call the SeedBooks method from your Seeding folder
                    //you will need to pass in the instance of AppDbContext
                    //that you set in the constructor
                    Seeding.SeedAccounts.SeedAllAccounts(_context);
                }
                catch (Exception ex)
                {
                    //add the error messages to a list of strings
                    List<String> errorList = new List<String>();

                    errorList.Add("There was a problem adding this property.");

                    //Add the outer message
                    errorList.Add(ex.Message);

                    //Add the message from the inner exception, if there is one
                    if (ex.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.Message);
                    }

                    //Add additional inner exception messages, if there are any
                    if (ex.InnerException.InnerException != null)
                    {
                        errorList.Add(ex.InnerException.InnerException.Message);
                    }

                    //return the user to the error view
                    return View("Error", errorList);
                }

                //everything is okay - send user to confirmation page
                return View("Confirm");
            }
        }
    } 