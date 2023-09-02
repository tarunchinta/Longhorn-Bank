using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
namespace fa22_finalproject_32.Models
{
    public enum AccountType { [Display(Name = "Savings")] Savings, [Display(Name = "Checking")] Checking, [Display(Name = "IRA")] IRA}

    public class Account
    {

        [Display(Name = "Account Number")]
        public Int64 AccountID { get; set; }

        public String AccountNumber { get; set; }

        [Display(Name = "Account Name")]
        public String AccountName { get; set; }

        //[Display(Name = "Account Number")]
        //public UInt32 AccountNumber { get; set; }

        [Display(Name = "Type")]
        public AccountType AccountType { get; set; }

        [Display(Name = "Balance")]
        [DisplayFormat(DataFormatString = "{0:c}")]

        public Decimal Balance
        {
            get 
            {
                Decimal total = 0;
                foreach (Transaction t in Transactions)
                {
                    if (t.TransactionType == TransactionType.Deposit)
                    {
                        total += t.Amount;
                    }
                    else if (t.TransactionType == TransactionType.Withdraw || t.TransactionType == TransactionType.Fee)
                    {
                        total -= t.Amount;
                    }
                    else
                    {
                        if (this.AccountNumber == t.FromAccount)
                        {
                            total -= t.Amount;
                        }
                        else
                        {
                            total += t.Amount;
                        }
                    }
                }
                return total; 
            }
        }


        public Decimal IRAContribution
        {
            get
            {
                Decimal total = 0;
                foreach (Transaction t in Transactions)
                {
                    if (t.TransactionType == TransactionType.Deposit)
                    {
                        total += t.Amount;
                    }
                    else if (t.TransactionType == TransactionType.Transfer)
                    {
                        if (this.AccountNumber == t.ToAccount)
                        {
                            total += t.Amount;
                        }
                    }
                }
                return total;
            }
        }

        public string hiddenAccountNumber
        {
            get { return AccountNumber.Substring(6); }
        }
        public AppUser AppUser { get; set; }

        public List<Transaction> Transactions { get; set; }

        public Account()
        {
            //string hiddenAccountNumber = "*****" + AccountNumber.Substring(6);

            if (Transactions == null)
            {
                Transactions = new List<Transaction>();

            }
       
         }

    }
}
