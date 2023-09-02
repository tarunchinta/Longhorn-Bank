
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

    public static class SeedCustomers
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
                    UserName = "cbaker@freezing.co.uk",
                    Email = "cbaker@freezing.co.uk",
                    PhoneNumber = "5125571146",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Christopher",
                    LastName = "Baker",
                    MI = "L",
                    Address = "1245 Lake Austin Blvd.",
                    City = "1245 Lake Austin Blvd.",
                    State = "1245 Lake Austin Blvd.",
                    ZipCode = "78733",
                    Birthday = new DateTime(1991-02-07 00:00:00 )                },
                Password = "gazing",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mb@aool.com",
                    Email = "mb@aool.com",
                    PhoneNumber = "2102678873",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Michelle",
                    LastName = "Banks",
                    MI = "nan",
                    Address = "1300 Tall Pine Lane",
                    City = "1300 Tall Pine Lane",
                    State = "1300 Tall Pine Lane",
                    ZipCode = "78261",
                    Birthday = new DateTime(1990-06-23 00:00:00 )                },
                Password = "banquet",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "fd@aool.com",
                    Email = "fd@aool.com",
                    PhoneNumber = "8175659699",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Franco",
                    LastName = "Broccolo",
                    MI = "V",
                    Address = "62 Browning Rd",
                    City = "62 Browning Rd",
                    State = "62 Browning Rd",
                    ZipCode = "77019",
                    Birthday = new DateTime(1986-05-06 00:00:00 )                },
                Password = "666666",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wendy@ggmail.com",
                    Email = "wendy@ggmail.com",
                    PhoneNumber = "5125943222",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Wendy",
                    LastName = "Chang",
                    MI = "L",
                    Address = "202 Bellmont Hall",
                    City = "202 Bellmont Hall",
                    State = "202 Bellmont Hall",
                    ZipCode = "78713",
                    Birthday = new DateTime(1964-12-21 00:00:00 )                },
                Password = "clover",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "limchou@yaho.com",
                    Email = "limchou@yaho.com",
                    PhoneNumber = "2107724599",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lim",
                    LastName = "Chou",
                    MI = "nan",
                    Address = "1600 Teresa Lane",
                    City = "1600 Teresa Lane",
                    State = "1600 Teresa Lane",
                    ZipCode = "78266",
                    Birthday = new DateTime(1950-06-14 00:00:00 )                },
                Password = "austin",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "Dixon@aool.com",
                    Email = "Dixon@aool.com",
                    PhoneNumber = "2142643255",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Shan",
                    LastName = "Dixon",
                    MI = "D",
                    Address = "234 Holston Circle",
                    City = "234 Holston Circle",
                    State = "234 Holston Circle",
                    ZipCode = "75208",
                    Birthday = new DateTime(1930-05-09 00:00:00 )                },
                Password = "mailbox",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "louann@ggmail.com",
                    Email = "louann@ggmail.com",
                    PhoneNumber = "8172556749",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Lou Ann",
                    LastName = "Feeley",
                    MI = "K",
                    Address = "600 S 8th Street W",
                    City = "600 S 8th Street W",
                    State = "600 S 8th Street W",
                    ZipCode = "77010",
                    Birthday = new DateTime(1930-02-24 00:00:00 )                },
                Password = "aggies",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tfreeley@minntonka.ci.state.mn.us",
                    Email = "tfreeley@minntonka.ci.state.mn.us",
                    PhoneNumber = "8173255687",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Tesa",
                    LastName = "Freeley",
                    MI = "P",
                    Address = "4448 Fairview Ave.",
                    City = "4448 Fairview Ave.",
                    State = "4448 Fairview Ave.",
                    ZipCode = "77009",
                    Birthday = new DateTime(1935-09-01 00:00:00 )                },
                Password = "raiders",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mgar@aool.com",
                    Email = "mgar@aool.com",
                    PhoneNumber = "8176593544",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Margaret",
                    LastName = "Garcia",
                    MI = "L",
                    Address = "594 Longview",
                    City = "594 Longview",
                    State = "594 Longview",
                    ZipCode = "77003",
                    Birthday = new DateTime(1990-07-03 00:00:00 )                },
                Password = "mustangs",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "chaley@thug.com",
                    Email = "chaley@thug.com",
                    PhoneNumber = "2148475583",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    LastName = "Haley",
                    MI = "E",
                    Address = "One Cowboy Pkwy",
                    City = "One Cowboy Pkwy",
                    State = "One Cowboy Pkwy",
                    ZipCode = "75261",
                    Birthday = new DateTime(1985-09-17 00:00:00 )                },
                Password = "region",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jeff@ggmail.com",
                    Email = "jeff@ggmail.com",
                    PhoneNumber = "5126978613",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeffrey",
                    LastName = "Hampton",
                    MI = "T",
                    Address = "337 38th St.",
                    City = "337 38th St.",
                    State = "337 38th St.",
                    ZipCode = "78705",
                    Birthday = new DateTime(1995-01-23 00:00:00 )                },
                Password = "hungry",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "wjhearniii@umch.edu",
                    Email = "wjhearniii@umch.edu",
                    PhoneNumber = "2148965621",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Hearn",
                    MI = "B",
                    Address = "4225 North First",
                    City = "4225 North First",
                    State = "4225 North First",
                    ZipCode = "75237",
                    Birthday = new DateTime(1994-01-08 00:00:00 )                },
                Password = "logicon",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "hicks43@ggmail.com",
                    Email = "hicks43@ggmail.com",
                    PhoneNumber = "2105788965",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anthony",
                    LastName = "Hicks",
                    MI = "J",
                    Address = "32 NE Garden Ln., Ste 910",
                    City = "32 NE Garden Ln., Ste 910",
                    State = "32 NE Garden Ln., Ste 910",
                    ZipCode = "78239",
                    Birthday = new DateTime(1990-10-06 00:00:00 )                },
                Password = "doofus",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "bradsingram@mall.utexas.edu",
                    Email = "bradsingram@mall.utexas.edu",
                    PhoneNumber = "5124678821",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Brad",
                    LastName = "Ingram",
                    MI = "S",
                    Address = "6548 La Posada Ct.",
                    City = "6548 La Posada Ct.",
                    State = "6548 La Posada Ct.",
                    ZipCode = "78736",
                    Birthday = new DateTime(1984-04-12 00:00:00 )                },
                Password = "mother",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mother.Ingram@aool.com",
                    Email = "mother.Ingram@aool.com",
                    PhoneNumber = "5124653365",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Todd",
                    LastName = "Jacobs",
                    MI = "L",
                    Address = "4564 Elm St.",
                    City = "4564 Elm St.",
                    State = "4564 Elm St.",
                    ZipCode = "78731",
                    Birthday = new DateTime(1983-04-04 00:00:00 )                },
                Password = "whimsical",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "victoria@aool.com",
                    Email = "victoria@aool.com",
                    PhoneNumber = "5129457399",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Victoria",
                    LastName = "Lawrence",
                    MI = "M",
                    Address = "6639 Butterfly Ln.",
                    City = "6639 Butterfly Ln.",
                    State = "6639 Butterfly Ln.",
                    ZipCode = "78761",
                    Birthday = new DateTime(1961-02-03 00:00:00 )                },
                Password = "nothing",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "lineback@flush.net",
                    Email = "lineback@flush.net",
                    PhoneNumber = "2102449976",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Erik",
                    LastName = "Lineback",
                    MI = "W",
                    Address = "1300 Netherland St",
                    City = "1300 Netherland St",
                    State = "1300 Netherland St",
                    ZipCode = "78293",
                    Birthday = new DateTime(1946-09-03 00:00:00 )                },
                Password = "GoodFellow",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "elowe@netscrape.net",
                    Email = "elowe@netscrape.net",
                    PhoneNumber = "2105344627",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Ernest",
                    LastName = "Lowe",
                    MI = "S",
                    Address = "3201 Pine Drive",
                    City = "3201 Pine Drive",
                    State = "3201 Pine Drive",
                    ZipCode = "78279",
                    Birthday = new DateTime(1992-02-07 00:00:00 )                },
                Password = "impede",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "luce_chuck@ggmail.com",
                    Email = "luce_chuck@ggmail.com",
                    PhoneNumber = "2106983548",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Chuck",
                    LastName = "Luce",
                    MI = "B",
                    Address = "2345 Rolling Clouds",
                    City = "2345 Rolling Clouds",
                    State = "2345 Rolling Clouds",
                    ZipCode = "78268",
                    Birthday = new DateTime(1942-10-25 00:00:00 )                },
                Password = "LuceyDucey",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mackcloud@pimpdaddy.com",
                    Email = "mackcloud@pimpdaddy.com",
                    PhoneNumber = "5124748138",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jennifer",
                    LastName = "MacLeod",
                    MI = "D",
                    Address = "2504 Far West Blvd.",
                    City = "2504 Far West Blvd.",
                    State = "2504 Far West Blvd.",
                    ZipCode = "78731",
                    Birthday = new DateTime(1965-08-06 00:00:00 )                },
                Password = "cloudyday",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "liz@ggmail.com",
                    Email = "liz@ggmail.com",
                    PhoneNumber = "5124579845",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Elizabeth",
                    LastName = "Markham",
                    MI = "P",
                    Address = "7861 Chevy Chase",
                    City = "7861 Chevy Chase",
                    State = "7861 Chevy Chase",
                    ZipCode = "78732",
                    Birthday = new DateTime(1959-04-13 00:00:00 )                },
                Password = "emarkbark",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "mclarence@aool.com",
                    Email = "mclarence@aool.com",
                    PhoneNumber = "8174955201",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clarence",
                    LastName = "Martin",
                    MI = "A",
                    Address = "87 Alcedo St.",
                    City = "87 Alcedo St.",
                    State = "87 Alcedo St.",
                    ZipCode = "77045",
                    Birthday = new DateTime(1990-01-06 00:00:00 )                },
                Password = "smartinmartin",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "smartinmartin.Martin@aool.com",
                    Email = "smartinmartin.Martin@aool.com",
                    PhoneNumber = "8178746718",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Gregory",
                    LastName = "Martinez",
                    MI = "R",
                    Address = "8295 Sunset Blvd.",
                    City = "8295 Sunset Blvd.",
                    State = "8295 Sunset Blvd.",
                    ZipCode = "77030",
                    Birthday = new DateTime(1987-10-09 00:00:00 )                },
                Password = "looter",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "cmiller@mapster.com",
                    Email = "cmiller@mapster.com",
                    PhoneNumber = "8177458615",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Charles",
                    LastName = "Miller",
                    MI = "R",
                    Address = "8962 Main St.",
                    City = "8962 Main St.",
                    State = "8962 Main St.",
                    ZipCode = "77031",
                    Birthday = new DateTime(1984-07-21 00:00:00 )                },
                Password = "chucky33",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "nelson.Kelly@aool.com",
                    Email = "nelson.Kelly@aool.com",
                    PhoneNumber = "5122926966",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Kelly",
                    LastName = "Nelson",
                    MI = "T",
                    Address = "2601 Red River",
                    City = "2601 Red River",
                    State = "2601 Red River",
                    ZipCode = "78703",
                    Birthday = new DateTime(1956-07-04 00:00:00 )                },
                Password = "orange",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jojoe@ggmail.com",
                    Email = "jojoe@ggmail.com",
                    PhoneNumber = "2143125897",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Joe",
                    LastName = "Nguyen",
                    MI = "C",
                    Address = "1249 4th SW St.",
                    City = "1249 4th SW St.",
                    State = "1249 4th SW St.",
                    ZipCode = "75238",
                    Birthday = new DateTime(1963-01-29 00:00:00 )                },
                Password = "victorious",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "orielly@foxnets.com",
                    Email = "orielly@foxnets.com",
                    PhoneNumber = "2103450925",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Bill",
                    LastName = "O'Reilly",
                    MI = "T",
                    Address = "8800 Gringo Drive",
                    City = "8800 Gringo Drive",
                    State = "8800 Gringo Drive",
                    ZipCode = "78260",
                    Birthday = new DateTime(1983-01-07 00:00:00 )                },
                Password = "billyboy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "or@aool.com",
                    Email = "or@aool.com",
                    PhoneNumber = "2142345566",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Anka",
                    LastName = "Radkovich",
                    MI = "L",
                    Address = "1300 Elliott Pl",
                    City = "1300 Elliott Pl",
                    State = "1300 Elliott Pl",
                    ZipCode = "75260",
                    Birthday = new DateTime(1980-03-31 00:00:00 )                },
                Password = "radicalone",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "megrhodes@freezing.co.uk",
                    Email = "megrhodes@freezing.co.uk",
                    PhoneNumber = "5123744746",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Megan",
                    LastName = "Rhodes",
                    MI = "C",
                    Address = "4587 Enfield Rd.",
                    City = "4587 Enfield Rd.",
                    State = "4587 Enfield Rd.",
                    ZipCode = "78707",
                    Birthday = new DateTime(1944-08-12 00:00:00 )                },
                Password = "gohorns",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "erynrice@aool.com",
                    Email = "erynrice@aool.com",
                    PhoneNumber = "5123876657",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eryn",
                    LastName = "Rice",
                    MI = "M",
                    Address = "3405 Rio Grande",
                    City = "3405 Rio Grande",
                    State = "3405 Rio Grande",
                    ZipCode = "78705",
                    Birthday = new DateTime(1934-08-02 00:00:00 )                },
                Password = "iloveme",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jorge@hootmail.com",
                    Email = "jorge@hootmail.com",
                    PhoneNumber = "8178904374",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jorge",
                    LastName = "Rodriguez",
                    MI = "nan",
                    Address = "6788 Cotter Street",
                    City = "6788 Cotter Street",
                    State = "6788 Cotter Street",
                    ZipCode = "77057",
                    Birthday = new DateTime(1989-08-11 00:00:00 )                },
                Password = "greedy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ra@aoo.com",
                    Email = "ra@aoo.com",
                    PhoneNumber = "5128752943",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    LastName = "Rogers",
                    MI = "B",
                    Address = "4965 Oak Hill",
                    City = "4965 Oak Hill",
                    State = "4965 Oak Hill",
                    ZipCode = "78732",
                    Birthday = new DateTime(1967-08-27 00:00:00 )                },
                Password = "familiar",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "st-jean@home.com",
                    Email = "st-jean@home.com",
                    PhoneNumber = "2104145678",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Olivier",
                    LastName = "Saint-Jean",
                    MI = "M",
                    Address = "255 Toncray Dr.",
                    City = "255 Toncray Dr.",
                    State = "255 Toncray Dr.",
                    ZipCode = "78292",
                    Birthday = new DateTime(1950-07-08 00:00:00 )                },
                Password = "historical",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ss34@ggmail.com",
                    Email = "ss34@ggmail.com",
                    PhoneNumber = "5123497810",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Sarah",
                    LastName = "Saunders",
                    MI = "J",
                    Address = "332 Avenue C",
                    City = "332 Avenue C",
                    State = "332 Avenue C",
                    ZipCode = "78705",
                    Birthday = new DateTime(1977-10-29 00:00:00 )                },
                Password = "guiltless",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "willsheff@email.com",
                    Email = "willsheff@email.com",
                    PhoneNumber = "5124510084",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "William",
                    LastName = "Sewell",
                    MI = "T",
                    Address = "2365 51st St.",
                    City = "2365 51st St.",
                    State = "2365 51st St.",
                    ZipCode = "78709",
                    Birthday = new DateTime(1941-04-21 00:00:00 )                },
                Password = "frequent",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "sheff44@ggmail.com",
                    Email = "sheff44@ggmail.com",
                    PhoneNumber = "5125479167",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Martin",
                    LastName = "Sheffield",
                    MI = "J",
                    Address = "3886 Avenue A",
                    City = "3886 Avenue A",
                    State = "3886 Avenue A",
                    ZipCode = "78705",
                    Birthday = new DateTime(1937-11-10 00:00:00 )                },
                Password = "history",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "johnsmith187@aool.com",
                    Email = "johnsmith187@aool.com",
                    PhoneNumber = "2108321888",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "John",
                    LastName = "Smith",
                    MI = "A",
                    Address = "23 Hidden Forge Dr.",
                    City = "23 Hidden Forge Dr.",
                    State = "23 Hidden Forge Dr.",
                    ZipCode = "78280",
                    Birthday = new DateTime(1954-10-26 00:00:00 )                },
                Password = "squirrel",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "dustroud@mail.com",
                    Email = "dustroud@mail.com",
                    PhoneNumber = "2142346667",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Dustin",
                    LastName = "Stroud",
                    MI = "P",
                    Address = "1212 Rita Rd",
                    City = "1212 Rita Rd",
                    State = "1212 Rita Rd",
                    ZipCode = "75221",
                    Birthday = new DateTime(1932-09-01 00:00:00 )                },
                Password = "snakes",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "ericstuart@aool.com",
                    Email = "ericstuart@aool.com",
                    PhoneNumber = "5128178335",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Eric",
                    LastName = "Stuart",
                    MI = "D",
                    Address = "5576 Toro Ring",
                    City = "5576 Toro Ring",
                    State = "5576 Toro Ring",
                    ZipCode = "78746",
                    Birthday = new DateTime(1930-12-28 00:00:00 )                },
                Password = "landus",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "peterstump@hootmail.com",
                    Email = "peterstump@hootmail.com",
                    PhoneNumber = "8174560903",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Peter",
                    LastName = "Stump",
                    MI = "L",
                    Address = "1300 Kellen Circle",
                    City = "1300 Kellen Circle",
                    State = "1300 Kellen Circle",
                    ZipCode = "77018",
                    Birthday = new DateTime(1989-08-13 00:00:00 )                },
                Password = "rhythm",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tanner@ggmail.com",
                    Email = "tanner@ggmail.com",
                    PhoneNumber = "8174590929",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jeremy",
                    LastName = "Tanner",
                    MI = "S",
                    Address = "4347 Almstead",
                    City = "4347 Almstead",
                    State = "4347 Almstead",
                    ZipCode = "77044",
                    Birthday = new DateTime(1982-05-21 00:00:00 )                },
                Password = "kindly",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "taylordjay@aool.com",
                    Email = "taylordjay@aool.com",
                    PhoneNumber = "5124748452",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allison",
                    LastName = "Taylor",
                    MI = "R",
                    Address = "467 Nueces St.",
                    City = "467 Nueces St.",
                    State = "467 Nueces St.",
                    ZipCode = "78705",
                    Birthday = new DateTime(1960-01-08 00:00:00 )                },
                Password = "instrument",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "TayTaylor@aool.com",
                    Email = "TayTaylor@aool.com",
                    PhoneNumber = "5124512631",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Rachel",
                    LastName = "Taylor",
                    MI = "K",
                    Address = "345 Longview Dr.",
                    City = "345 Longview Dr.",
                    State = "345 Longview Dr.",
                    ZipCode = "78705",
                    Birthday = new DateTime(1975-07-27 00:00:00 )                },
                Password = "arched",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "teefrank@hootmail.com",
                    Email = "teefrank@hootmail.com",
                    PhoneNumber = "8178765543",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Frank",
                    LastName = "Tee",
                    MI = "J",
                    Address = "5590 Lavell Dr",
                    City = "5590 Lavell Dr",
                    State = "5590 Lavell Dr",
                    ZipCode = "77004",
                    Birthday = new DateTime(1968-04-06 00:00:00 )                },
                Password = "median",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "tuck33@ggmail.com",
                    Email = "tuck33@ggmail.com",
                    PhoneNumber = "2148471154",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Clent",
                    LastName = "Tucker",
                    MI = "J",
                    Address = "312 Main St.",
                    City = "312 Main St.",
                    State = "312 Main St.",
                    ZipCode = "75315",
                    Birthday = new DateTime(1978-05-19 00:00:00 )                },
                Password = "approval",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "avelasco@yaho.com",
                    Email = "avelasco@yaho.com",
                    PhoneNumber = "2143985638",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Allen",
                    LastName = "Velasco",
                    MI = "G",
                    Address = "679 W. 4th",
                    City = "679 W. 4th",
                    State = "679 W. 4th",
                    ZipCode = "75207",
                    Birthday = new DateTime(1963-10-06 00:00:00 )                },
                Password = "decorate",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "westj@pioneer.net",
                    Email = "westj@pioneer.net",
                    PhoneNumber = "2148475244",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jake",
                    LastName = "West",
                    MI = "T",
                    Address = "RR 3287",
                    City = "RR 3287",
                    State = "RR 3287",
                    ZipCode = "75323",
                    Birthday = new DateTime(1993-10-14 00:00:00 )                },
                Password = "grover",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "louielouie@aool.com",
                    Email = "louielouie@aool.com",
                    PhoneNumber = "2145650098",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Louis",
                    LastName = "Winthorpe",
                    MI = "L",
                    Address = "2500 Padre Blvd",
                    City = "2500 Padre Blvd",
                    State = "2500 Padre Blvd",
                    ZipCode = "75220",
                    Birthday = new DateTime(1952-05-31 00:00:00 )                },
                Password = "sturdy",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "rwood@voyager.net",
                    Email = "rwood@voyager.net",
                    PhoneNumber = "5124545242",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Reagan",
                    LastName = "Wood",
                    MI = "B",
                    Address = "447 Westlake Dr.",
                    City = "447 Westlake Dr.",
                    State = "447 Westlake Dr.",
                    ZipCode = "78746",
                    Birthday = new DateTime(1992-04-24 00:00:00 )                },
                Password = "decorous",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "dman@wdwebsolutions.com",
                    Email = "dman@wdwebsolutions.com",
                    PhoneNumber = "5556409287",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Derek",
                    LastName = "Dreibrodt",
                    MI = "nan",
                    Address = "423 Brentwood Dr",
                    City = "423 Brentwood Dr",
                    State = "423 Brentwood Dr",
                    ZipCode = "78705",
                    Birthday = new DateTime(2001-01-01 00:00:00 )                },
                Password = "nasus123",
                RoleName = "Customer"
            });

            AllUsers.Add(new AddUserModel()
            {
                User = new AppUser()
                {
                    //populate the user properties that are from the 
                    //IdentityUser base class
                    UserName = "jman@outlook.com",
                    Email = "jman@outlook.com",
                    PhoneNumber = "5558471234",

                    // Add additional fields that you created on the AppUser class
                    //FirstName is included as an example
                    FirstName = "Jacob",
                    LastName = "Foster",
                    MI = "nan",
                    Address = "700 Fancy St",
                    City = "700 Fancy St",
                    State = "700 Fancy St",
                    ZipCode = "78705",
                    Birthday = new DateTime(2000-09-01 00:00:00 )                },
                Password = "pres4baseball",
                RoleName = "Customer"
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
