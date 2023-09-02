using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace fa22_finalproject_32.Models
{
    public enum Approved { [Display(Name = "Yes")] Yes, [Display(Name = "No")] No }
    public enum TransactionType { Withdraw, Deposit, Fee, Transfer }

    public enum Sort { Ascending, Descending }
    public enum SortBy { TransactionNumber, Type, Description, Amount, Date }

    public class Transaction
    {

        public Int32 TransactionID { get; set; }

        //[Required(ErrorMessage = "To Account is required.")]
        [Display(Name = "To Account")]
        public String ToAccount { get; set; }

        //[Required(ErrorMessage = "From Account is required.")]
        [Display(Name = "From Account")]
        public String FromAccount { get; set; }

        [Display(Name = "Transaction Comments")]
        public String TransactionComments { get; set; }

        [Required(ErrorMessage = "Amount is required.")]
        [Display(Name = "Amount")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        [Range(0, int.MaxValue)]
        public Decimal Amount { get; set; }

        public Approved Approved { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime DisputeDate { get; set; }


        public String User { get; set; }

        public Account Account { get; set; }

        public TransactionType TransactionType { get; set; }

        public List<Dispute> Disputes { get; set; }

        public Transaction()
        {
                Amount = 0;
            
            if (Disputes == null)
            {
                Disputes = new List<Dispute>();
            }
        }
    }
}
