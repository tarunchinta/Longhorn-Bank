
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

    public static class SeedEmployees
    {
        public async static Task<IdentityResult> SeedAllUsers(UserManager<AppUser> userManager, AppDbContext context)
        {
            //Create a list of AddUserModels
            List<AddUserModel> AllUsers = new List<AddUserModel>();


            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "t.jacobs@longhornbank.neet",
                    Email = "t.jacobs@longhornbank.neet",
                    PhoneNumber = "8176593544",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    Address = "4564 Elm St.",
                    EmpType = EmpType.Employee,
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77003",
                    SSN = 222222222
                },
                Password = "society",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "e.rice@longhornbank.neet",
                    Email = "e.rice@longhornbank.neet",
                    PhoneNumber = "2148475583",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eryn",
                    LastName = "Rice",
                    Address = "3405 Rio Grande",
                    EmpType = EmpType.Employee,
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75261",
                    SSN = 111111111
                },
                Password = "ricearoni",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "b.ingram@longhornbank.neet",
                    Email = "b.ingram@longhornbank.neet",
                    PhoneNumber = "5126978613",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    LastName = "Ingram",
                    Address = "6548 La Posada Ct.",
                    EmpType = EmpType.Employee,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    SSN = 545454545
                },
                Password = "ingram45",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "a.taylor@longhornbank.neet",
                    Email = "a.taylor@longhornbank.neet",
                    PhoneNumber = "2148965621",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allison",
                    LastName = "Taylor",
                    Address = "467 Nueces St.",
                    EmpType = EmpType.Admin,
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75237",
                    SSN = 645889563
                },
                Password = "nostalgic",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "g.martinez@longhornbank.neet",
                    Email = "g.martinez@longhornbank.neet",
                    PhoneNumber = "2105788965",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    Address = "8295 Sunset Blvd.",
                    EmpType = EmpType.Employee,
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78239",
                    SSN = 574677829
                },
                Password = "fungus",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "m.sheffield@longhornbank.neet",
                    Email = "m.sheffield@longhornbank.neet",
                    PhoneNumber = "5124678821",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    Address = "3886 Avenue A",
                    EmpType = EmpType.Admin,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78736",
                    SSN = 334557278
                },
                Password = "longhorns",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "j.macleod@longhornbank.neet",
                    Email = "j.macleod@longhornbank.neet",
                    PhoneNumber = "5124653365",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    Address = "2504 Far West Blvd.",
                    EmpType = EmpType.Admin,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78731",
                    SSN = 886719249
                },
                Password = "smitty",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "j.tanner@longhornbank.neet",
                    Email = "j.tanner@longhornbank.neet",
                    PhoneNumber = "5129457399",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    Address = "4347 Almstead",
                    EmpType = EmpType.Employee,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78761",
                    SSN = 888887878
                },
                Password = "tanman",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "m.rhodes@longhornbank.neet",
                    Email = "m.rhodes@longhornbank.neet",
                    PhoneNumber = "2102449976",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    Address = "4587 Enfield Rd.",
                    EmpType = EmpType.Admin,
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78293",
                    SSN = 999990909
                },
                Password = "countryrhodes",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "e.stuart@longhornbank.neet",
                    Email = "e.stuart@longhornbank.neet",
                    PhoneNumber = "2105344627",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eric",
                    LastName = "Stuart",
                    Address = "5576 Toro Ring",
                    EmpType = EmpType.Admin,
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78279",
                    SSN = 212121212
                },
                Password = "stewboy",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "l.chung@longhornbank.neet",
                    Email = "l.chung@longhornbank.neet",
                    PhoneNumber = "2106983548",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lisa",
                    LastName = "Chung",
                    Address = "234 RR 12",
                    EmpType = EmpType.Employee,
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78268",
                    SSN = 333333333
                },
                Password = "lisssa",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "l.swanson@longhornbank.neet",
                    Email = "l.swanson@longhornbank.neet",
                    PhoneNumber = "5124748138",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Leon",
                    LastName = "Swanson",
                    Address = "245 River Rd",
                    EmpType = EmpType.Admin,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78731",
                    SSN = 444444444
                },
                Password = "swansong",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "w.loter@longhornbank.neet",
                    Email = "w.loter@longhornbank.neet",
                    PhoneNumber = "5124579845",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wanda",
                    LastName = "Loter",
                    Address = "3453 RR 3235",
                    EmpType = EmpType.Employee,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78732",
                    SSN = 555555555
                },
                Password = "lottery",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "j.white@longhornbank.neet",
                    Email = "j.white@longhornbank.neet",
                    PhoneNumber = "8174955201",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jason",
                    LastName = "White",
                    Address = "12 Valley View",
                    EmpType = EmpType.Admin,
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77045",
                    SSN = 666666666
                },
                Password = "evanescent",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "w.montgomery@longhornbank.neet",
                    Email = "w.montgomery@longhornbank.neet",
                    PhoneNumber = "8178746718",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wilda",
                    LastName = "Montgomery",
                    Address = "210 Blanco Dr",
                    EmpType = EmpType.Admin,
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77030",
                    SSN = 676767676
                },
                Password = "monty3",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "h.morales@longhornbank.neet",
                    Email = "h.morales@longhornbank.neet",
                    PhoneNumber = "8177458615",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Hector",
                    LastName = "Morales",
                    Address = "4501 RR 140",
                    EmpType = EmpType.Employee,
                    City = "Houston",
                    State = "TX",
                    ZipCode = "77031",
                    SSN = 898989898
                },
                Password = "hecktour",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "m.rankin@longhornbank.neet",
                    Email = "m.rankin@longhornbank.neet",
                    PhoneNumber = "5122926966",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Mary",
                    LastName = "Rankin",
                    Address = "340 Second St",
                    EmpType = EmpType.Employee,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78703",
                    SSN = 999888777
                },
                Password = "rankmary",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "l.walker@longhornbank.neet",
                    Email = "l.walker@longhornbank.neet",
                    PhoneNumber = "2143125897",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Larry",
                    LastName = "Walker",
                    Address = "9 Bison Circle",
                    EmpType = EmpType.Admin,
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75238",
                    SSN = 323232323
                },
                Password = "walkamile",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "g.chang@longhornbank.neet",
                    Email = "g.chang@longhornbank.neet",
                    PhoneNumber = "2103450925",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "George",
                    LastName = "Chang",
                    Address = "9003 Joshua St",
                    EmpType = EmpType.Admin,
                    City = "San Antonio",
                    State = "TX",
                    ZipCode = "78260",
                    SSN = 111222233
                },
                Password = "changalang",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "g.gonzalez@longhornbank.neet",
                    Email = "g.gonzalez@longhornbank.neet",
                    PhoneNumber = "2142345566",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Gwen",
                    LastName = "Gonzalez",
                    Address = "103 Manor Rd",
                    EmpType = EmpType.Employee,
                    City = "Dallas",
                    State = "TX",
                    ZipCode = "75260",
                    SSN = 499551454
                },
                Password = "offbeat",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "dman@longhornbank.neet",
                    Email = "dman@longhornbank.neet",
                    PhoneNumber = "5556409287",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Derek",
                    LastName = "Dreibrodt",
                    Address = "423 Brentwood Dr",
                    EmpType = EmpType.Admin,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    SSN = 123123123
                },
                Password = "nasus123",
                RoleName = "Employee"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jman@longhornbank.neet",
                    Email = "jman@longhornbank.neet",
                    PhoneNumber = "5558471234",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jacob",
                    LastName = "Foster",
                    Address = "700 Fancy St",
                    EmpType = EmpType.Admin,
                    City = "Austin",
                    State = "TX",
                    ZipCode = "78705",
                    SSN = 555555551
                },
                Password = "pres4baseball",
                RoleName = "Employee"
            });

            //create flag to help with errors
            String errorFlag = "Start";

            //create an identity result
            IdentityResult result = new IdentityResult();
            //call the method to seed the user
            try
            {
                foreach (AddUserModel aum in AllUsers)
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
