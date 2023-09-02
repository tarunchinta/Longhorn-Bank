using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace fa22_finalproject_32.Models
{
    public class StockPortfolio
    {
        public Int32 StockPortfolioID { get; set; }

        [Display(Name = "Cash Balance")]
        public decimal CashBalance { get; set; }
        public String AccountName { get; set; }
        public String AccountNumber { get; set; }
        //public bool Balanced { get; set; }
        public AppUser AppUser { get; set; }

        public List<StockTransaction> StockTransactions { get; set; }

        public StockPortfolio()
        {
            if (StockTransactions == null)
            {
                StockTransactions = new List<StockTransaction>();
            }
        }
    }
}
