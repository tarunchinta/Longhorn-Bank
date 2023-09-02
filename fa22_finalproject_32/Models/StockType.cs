using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace fa22_finalproject_32.Models
{
    //public enum StockTypeName { [Display(Name = "Ordinary Stock")] Ordinary, [Display(Name = "Index Fund")] index_fund, [Display(Name = "Exchange-Traded Fund (ETF)")] etf, [Display(Name = "Mutual Fund")] mutual_fund, [Display(Name = "Future Share")] future_share, }

    public class StockType
    {
        public int StockTypeID { get; set; }

        [Display(Name = "Stock Type Name")]
        public StockTypeName StockTypeName { get; set; }

        public List<Stock> Stocks { get; set; }

        public StockType()
        {
            if (Stocks == null)
            {
                Stocks = new List<Stock>();
            }
        }
    }
}
