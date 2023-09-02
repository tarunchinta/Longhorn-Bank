using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

 
namespace fa22_finalproject_32.Models
{
    public enum RoleType { [Display(Name = "Admin")] Admin, [Display(Name = "Employee")] Employee }

    public class AppUser : IdentityUser
    {
        //TODO: Add custom user fields - first name is included as an example
        [Required(ErrorMessage = "First name is required.")]

        [Display(Name = "First Name")]
        public String FirstName { get; set; }

        [Required(ErrorMessage = "Last name is required.")]
        [Display(Name = "Last Name")]
        public String LastName { get; set; }

        [Display(Name = "Middle Initial")]
        public string MI { get; set; }

        //[Required(ErrorMessage = "Address is required.")]
        //[Display(Name = "Address")]
        //public String Address { get; set; }

        [Required(ErrorMessage = "Address is required.")]
        [Display(Name = "Address")]
        public string Address { get; set; }

        [Required(ErrorMessage = "City is required.")]
        public string City { get; set; }

        [Required(ErrorMessage = "State is required.")]
        public string State { get; set; }

        [Required(ErrorMessage = "Zip code is required.")]
        [Display(Name = "Zip code")]
        public string ZipCode { get; set; }


        [Display(Name = "Birthday")]

        public DateTime Birthday { get; set; }

        [Display(Name = "SSN")]

        public Int32 SSN { get; set; }

        [Display(Name = "Employee Type")]

        public RoleType RoleType { get; set; }

        public String SelectedRole { get; set; }



        public StockPortfolio StockPortfolio { get; set; }

        public List<Account> Accounts { get; set; }

        public AppUser()
        {
            if (Accounts == null)
            {
                Accounts = new List<Account>();
            }
        }
    }
}
