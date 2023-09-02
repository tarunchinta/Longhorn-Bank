using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace fa22_finalproject_32.Models
{
    public enum StockTypeName { [Display(Name = "Ordinary Stock")] Ordinary, [Display(Name = "Index Fund")] index_fund, [Display(Name = "Exchange-Traded Fund (ETF)")] etf, [Display(Name = "Mutual Fund")] mutual_fund, [Display(Name = "Future Share")] future_share, }

    public class Stock
    {
        public Int32 StockID { get; set; }

        [Display(Name = "Stock Ticker")]
        public String StockTicker { get; set; }

        [Display(Name = "Stock Type")]
        public StockTypeName StockTypeName { get; set; }

        [Display(Name = "Stock Price:")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public Decimal Price { get; set; }

        [Display(Name = "Stock Name")]
        public String StockName { get; set; }

        //[Display(Name = "Stock Type")]
        //public String StockTypeName { get; set; }

        public List<StockTransaction> StockTransactions { get; set; }

        public Stock()
        {
            if (StockTransactions == null)
            {
                StockTransactions = new List<StockTransaction>();
            }
        }
    }
}
