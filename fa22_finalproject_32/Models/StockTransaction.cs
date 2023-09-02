using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace fa22_finalproject_32.Models
{
    public class StockTransaction
    {

        public Int32 StockTransactionID { get; set; }

        [Display(Name = "Number of Shares")]
        public Int32 NumofShares { get; set; }

        [Display(Name = "Price per share")]
        //[Range(0, Int32.MaxValue, ErrorMessage = "The Price must be at least zero")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Pricepershare { get; set; }

        [Display(Name = "Date")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:M/dd/yyyy}")]
        public DateTime StockTransactionDate { get; set; }

        public String PortfolioOwner { get; set; }

        public String StockType { get; set; }

        public String AssociatedCashBalanceAccount { get; set; }


        public String SelectedStock { get; set; }



        public StockPortfolio StockPortfolio { get; set; }
        public Stock Stock { get; set; }
        
        
        //public AppUser Appuser { get; set; }

    }
}
