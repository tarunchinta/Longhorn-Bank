using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;

namespace fa22_finalproject_32.Models.ViewModels
{
    //In actual model 
    //    public enum TransactionType {Withdrawal, Deposit, Fee }


    public class SearchViewModel
    {

        [Display(Name = "Search by Description:")]
        public string TransactionComments { get; set; }

        [Display(Name = "Search by Type:")]
        public TransactionType? SelectedTransactionType { get; set; }

        [Display(Name = "Minimum Amount:")]
        public Decimal? MinAmount { get; set; }

        [Display(Name = "Maximum Amount:")]
        public Decimal? MaxAmount { get; set; }

        [Display(Name = "Transaction Number:")]
        public Int32? TransactionId { get; set; }

        [Display(Name = "Earliest Date:")]
        [DataType(DataType.Date)]
        public DateTime? EarliestDate { get; set; }

        [Display(Name = "Latest Date:")]
        [DataType(DataType.Date)]
        public DateTime? LatestDate { get; set; }

        [Display(Name = "Sort:")]
        public Sort? SelectedSort { get; set; }


        [Display(Name = "SelectedSortBy:")]
        public SortBy? SelectedSortBy { get; set; }

    }
}
