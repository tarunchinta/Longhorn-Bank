using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

public enum Status { [Display(Name = "Submitted")] submitted, [Display(Name = "Not Submitted")] notsubmitted }


namespace fa22_finalproject_32.Models
{
    public class Dispute
    {
        [Display(Name = "DisputeID")]
        public Int32 DisputeID { get; set; }

        [Display(Name = "Correct Amount")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal CorrectAmount { get; set; }

        [Display(Name = "Dispute Description")]

        public String DisputeDescription { get; set; }

        [Display(Name = "Selected Status")]
        public Status Status { get; set; }

        public String Customer { get; set; }

        //   [Required]
        //   public bool Delete { get; set; }

        public  Transaction Transaction { get; set; }
    }
}
