using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa22_finalproject_32.DAL;
using fa22_finalproject_32.Models;
using fa22_finalproject_32.Models.ViewModels;
using NuGet.Protocol.Core.Types;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Security.Principal;
using static NuGet.Packaging.PackagingConstants;
using fa22_finalproject_32.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace fa22_finalproject_32.Controllers
{
    [Authorize]
    public class TransactionsController : Controller
    {
        private readonly AppDbContext _context;

        public TransactionsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: Transactions
        public async Task<IActionResult> Index()
        {
            List<Transaction> Transactions = new List<Transaction>();
            if (User.IsInRole("Admin") == false)
            {
                Transactions = _context.Transactions.Where(o => o.User == User.Identity.Name).Include(ord => ord.Disputes).ToList();
            }
            else
            {
                Transactions = _context.Transactions.Include(o => o.Disputes).ToList();
            }

            return View(Transactions);
        }

        // GET: Transactions/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null || _context.Transactions == null)
            {
                return NotFound();
            }

            Transaction transaction = _context.Transactions
                        .Include(ord => ord.Disputes)
                        .Include(ord => ord.Account)
                        .FirstOrDefault(o => o.TransactionID == id);
            if (transaction == null)
            {
                return NotFound();
            }

            return View(transaction);
        }

        private SelectList GetAccountSelectList()
        {
            //create a list for all the products
            List<Account> allAccounts = _context.Accounts.Where(o => o.AppUser.Email == User.Identity.Name).ToList();

            //the user MUST select a product, so you don't need a dummy option for no product

            //use the constructor on select list to create a new select list with the options
            SelectList slAllAccounts = new SelectList(allAccounts, nameof(Account.AccountID), nameof(Account.AccountName));

            return slAllAccounts;
        }

        // GET: Transactions/Create
        public IActionResult Create()
        {
            ViewBag.AllAccounts = GetAccountSelectList();
            return View();
        }

        // POST: Transactions/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
 
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Transaction transaction, int? SelectedFromAccount, int? SelectedToAccount)
        {
            if (ModelState.IsValid == false)
            {
                ViewBag.AllAccounts = GetAccountSelectList();
                return View(transaction);
            }

            if (transaction.TransactionType == TransactionType.Withdraw)
            {
                Account dbAccount = _context.Accounts.Find(SelectedFromAccount);

                if (transaction.Amount > dbAccount.Balance)
                {
                    return View("Error", new String[] { "You do not have enough amount in this account!" });
                }

                transaction.FromAccount = dbAccount.AccountNumber;
                transaction.Account = dbAccount;

                dbAccount.Transactions.Add(transaction);
                _context.Update(dbAccount);
                await _context.SaveChangesAsync();
            }
            else if (transaction.TransactionType == TransactionType.Deposit)
            {
                Account dbAccount = _context.Accounts.Find(SelectedToAccount);

                //if (transaction.Amount > 5000)
                //{
                    //TODO: to Admin to approve
                //}

                transaction.ToAccount = dbAccount.AccountNumber;
                transaction.Account = dbAccount;

                dbAccount.Transactions.Add(transaction);
                _context.Update(dbAccount);
                await _context.SaveChangesAsync();
            }
            else
            {
                Account fromAccount = _context.Accounts.Find(SelectedFromAccount);
                Account toAccount = _context.Accounts.Find(SelectedToAccount);

                if (transaction.Amount > fromAccount.Balance)
                {
                    return View("Error", new String[] { "You do not have enough amount in this account!" });
                }

                transaction.FromAccount = fromAccount.AccountNumber;
                transaction.ToAccount = toAccount.AccountNumber;
                transaction.Account = fromAccount;


                toAccount.Transactions.Add(transaction);
                _context.Update(toAccount);
                await _context.SaveChangesAsync();

                fromAccount.Transactions.Add(transaction);
                _context.Update(fromAccount);
                await _context.SaveChangesAsync();
            }

            _context.Update(transaction);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Transactions", new { id = transaction.TransactionID });
        }

        private bool TransactionExists(int id)
        {
          return _context.Transactions.Any(e => e.TransactionID == id);
        }


        public IActionResult Deposit()
        {
            ViewBag.AllAccounts = GetAccountSelectList();
            ViewBag.Now = DateTime.Today.ToString("yyyy-MM-dd");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Deposit(Transaction transaction, Int64 SelectedToAccount)
        {
            if (ModelState.IsValid == false || transaction.DisputeDate < DateTime.Today)
            {
                ViewBag.AllAccounts = GetAccountSelectList();
                ViewBag.Now = DateTime.Today.ToString("yyyy-MM-dd");
                return View(transaction);
            }

            Account dbAccount = _context.Accounts.Include(ord => ord.AppUser)
                                                 .Include(ord => ord.Transactions)
                                                 .FirstOrDefault(x => x.AccountID == SelectedToAccount);

            if (dbAccount.AccountType == AccountType.IRA && dbAccount.IRAContribution + transaction.Amount > 5000)
            {
                ViewBag.AllAccounts = GetAccountSelectList();
                ViewBag.Now = DateTime.Today.ToString("yyyy-MM-dd");
                transaction.Amount = 5000 - dbAccount.IRAContribution;
                String errMsg = "";
                if (transaction.Amount > 0)
                {
                    ViewBag.errMsg = "You are only allowed to contribute $" + transaction.Amount + " to the IRA account this year!";
                }
                else
                {
                    transaction.Amount = 0;
                    ViewBag.errMsg = "You are not allowed to contribute to your IRA account anymore this year!";
                }

                ViewBag.Amount = transaction.Amount;
                return View(transaction);
            }

            //if (transaction.Amount > 5000)
            //{
            //TODO: to Admin to approve
            //}

            transaction.ToAccount = dbAccount.AccountNumber;
            transaction.Account = dbAccount;
            transaction.User = dbAccount.AppUser.UserName;
            transaction.TransactionType = TransactionType.Deposit;

            dbAccount.Transactions.Add(transaction);
            _context.Update(dbAccount);
            await _context.SaveChangesAsync();

            _context.Update(transaction);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Transactions", new { id = transaction.TransactionID });
        }

        public IActionResult Withdraw()
        {
            ViewBag.AllAccounts = GetAccountSelectList();
            ViewBag.Now = DateTime.Today.ToString("yyyy-MM-dd");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Withdraw(Transaction transaction, Int64 SelectedFromAccount)
        {
            if (ModelState.IsValid == false || transaction.DisputeDate < DateTime.Today)
            {
                ViewBag.AllAccounts = GetAccountSelectList();
                ViewBag.Now = DateTime.Today.ToString("yyyy-MM-dd");
                return View(transaction);
            }
             
            Account dbAccount = _context.Accounts.Include(ord => ord.AppUser)
                                                 .Include(ord => ord.Transactions)
                                                 .FirstOrDefault(x => x.AccountID == SelectedFromAccount);

            if (transaction.Amount > dbAccount.Balance)
            {
                return View("Error", new String[] { "You do not have enough amount in this account!" });
            }

            if (dbAccount.AccountType == AccountType.IRA)
            {
                if (dbAccount.AppUser.Birthday.AddYears(65) < DateTime.Today)
                {
                    if (transaction.Amount > 3000)
                    {
                        return View("Error", new String[] { "Maximum withdrawal amount is $3000 for user under 65 years old!" });
                    }

                    if (transaction.Amount + 30 > dbAccount.Balance)
                    {
                        return View("Error", new String[] { "You do not have enough amount for the fee in your IRA account!" });
                    }

                    Transaction fee = new Transaction();
                    fee.Amount = 30;
                    fee.Account = dbAccount;
                    fee.User = dbAccount.AppUser.UserName;
                    fee.TransactionType = TransactionType.Fee;
                    fee.DisputeDate = DateTime.Now;
                    dbAccount.Transactions.Add(fee);

                    _context.Update(fee);
                    await _context.SaveChangesAsync();
                }
            }

            transaction.FromAccount = dbAccount.AccountNumber;
            transaction.Account = dbAccount;
            transaction.User = dbAccount.AppUser.UserName;
            transaction.TransactionType = TransactionType.Withdraw;

            dbAccount.Transactions.Add(transaction);
            _context.Update(dbAccount);
            await _context.SaveChangesAsync();

            _context.Update(transaction);
            await _context.SaveChangesAsync();

            return RedirectToAction("Details", "Transactions", new { id = transaction.TransactionID });
        }

        public IActionResult Transfer()
        {
            ViewBag.AllAccounts = GetAccountSelectList();
            ViewBag.Now = DateTime.Today.ToString("yyyy-MM-dd");
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Transfer(Transaction transaction, Int64 SelectedFromAccount, Int64 SelectedToAccount)
        {
            if (ModelState.IsValid == false || transaction.DisputeDate < DateTime.Today)
            {
                ViewBag.AllAccounts = GetAccountSelectList();
                ViewBag.Now = DateTime.Today.ToString("yyyy-MM-dd");
                return View(transaction);
            }

            if (SelectedFromAccount == SelectedToAccount)
            {
                return View("Error", new String[] { "You are not allowed have same account for from and to!" });
            }

            Account fromAccount = _context.Accounts.Include(ord => ord.AppUser)
                                                 .Include(ord => ord.Transactions)
                                                 .FirstOrDefault(x => x.AccountID == SelectedFromAccount);

            if (transaction.Amount > fromAccount.Balance)
            {
                return View("Error", new String[] { "You do not have enough amount in this account!" });
            }

            if (fromAccount.AccountType == AccountType.IRA)
            {
                if (fromAccount.AppUser.Birthday.AddYears(65) < DateTime.Today)
                {
                    if (transaction.Amount > 3000)
                    {
                        return View("Error", new String[] { "Maximum withdrawal amount is $3000 for user under 65 years old!" });
                    }

                    if (transaction.Amount + 30 > fromAccount.Balance)
                    {
                        return View("Error", new String[] { "You do not have enough amount for the fee in your IRA account!" });
                    }

                    Transaction fee = new Transaction();
                    fee.Amount = 30;
                    fee.Account = fromAccount;
                    fee.User = fromAccount.AppUser.UserName;
                    fee.TransactionType = TransactionType.Fee;
                    fee.DisputeDate = DateTime.Now;
                    fromAccount.Transactions.Add(fee);

                    _context.Update(fee);
                    await _context.SaveChangesAsync();
                }
            }

            Account toAccount = _context.Accounts.Include(ord => ord.AppUser)
                                                 .Include(ord => ord.Transactions)
                                                 .FirstOrDefault(x => x.AccountID == SelectedToAccount);

            if (toAccount.AccountType == AccountType.IRA && toAccount.IRAContribution + transaction.Amount > 5000)
            {
                ViewBag.AllAccounts = GetAccountSelectList();
                ViewBag.Now = DateTime.Today.ToString("yyyy-MM-dd");
                transaction.Amount = 5000 - toAccount.IRAContribution;
                String errMsg = "";
                if (transaction.Amount > 0)
                {
                    ViewBag.errMsg = "You are only allowed to contribute $" + transaction.Amount + " to the IRA account this year!";
                }
                else
                {
                    transaction.Amount = 0;
                    ViewBag.errMsg = "You are not allowed to contribute to your IRA account anymore this year!";
                }

                ViewBag.Amount = transaction.Amount;
                return View(transaction);
            }


            Transaction fromTran = new Transaction();
            Transaction toTran = new Transaction();

            fromTran.Amount = transaction.Amount;
            fromTran.FromAccount = fromAccount.AccountNumber;
            fromTran.Account = fromAccount;
            fromTran.DisputeDate = transaction.DisputeDate;
            fromTran.User = fromAccount.AppUser.UserName;
            fromTran.TransactionType = TransactionType.Transfer;
            fromTran.TransactionComments = "Transfer from account " + fromAccount.AccountNumber.Substring(fromAccount.AccountNumber.Length - 4);

            toTran.Amount = transaction.Amount;
            toTran.ToAccount = toAccount.AccountNumber;
            toTran.Account = toAccount;
            toTran.DisputeDate = transaction.DisputeDate;
            toTran.User = toAccount.AppUser.UserName;
            toTran.TransactionType = TransactionType.Transfer;
            toTran.TransactionComments = "Transfer to account " + toAccount.AccountNumber.Substring(toAccount.AccountNumber.Length - 4);

            fromAccount.Transactions.Add(fromTran);
            _context.Update(fromAccount);
            await _context.SaveChangesAsync();

            toAccount.Transactions.Add(toTran);
            _context.Update(toAccount);
            await _context.SaveChangesAsync();

            _context.Update(fromTran);
            await _context.SaveChangesAsync();

            _context.Update(toTran);
            await _context.SaveChangesAsync();

            return RedirectToAction("DetailsTransfer", "Transactions", new { idFrom = fromTran.TransactionID, idTo = toTran.TransactionID });
        }


        public async Task<IActionResult> DetailsTransfer(int idFrom, int idTo)
        {
            if (idFrom == null || idTo == null || _context.Transactions == null)
            {
                return NotFound();
            }

            Transaction fromTran = _context.Transactions
                        .Include(ord => ord.Disputes)
                        .Include(ord => ord.Account)
                        .FirstOrDefault(o => o.TransactionID == idFrom);

            Transaction toTran = _context.Transactions
                        .Include(ord => ord.Disputes)
                        .Include(ord => ord.Account)
                        .FirstOrDefault(o => o.TransactionID == idTo);

            Transaction transaction = new Transaction();

            transaction.Amount = fromTran.Amount;
            transaction.FromAccount = fromTran.FromAccount;
            transaction.ToAccount = toTran.ToAccount;
            transaction.DisputeDate = fromTran.DisputeDate;
            transaction.TransactionComments = "Transfer from account " + transaction.FromAccount + " to account " + transaction.ToAccount;

            if (fromTran == null || toTran == null)
            {
                return NotFound();
            }

            return View("Details", transaction);
        }

        public async Task<IActionResult> DetailedSearch()
        {
            //ViewBag.AllTransactions = GetAllTransactions();

            return View();
            //return RedirectToAction(DisplaySearchResults, SearchViewModel svm));
        }


        [HttpPost]
        public async Task<IActionResult> DetailedSearch(SearchViewModel svm)
        {
            var query = from r in _context.Transactions
                        select r;

            if (String.IsNullOrEmpty(svm.TransactionComments) == false)  //(svm.Title != null && svm.Title != "")
            {
                query = query.Where(r => r.TransactionComments.Contains(svm.TransactionComments));
            }
            if (svm.SelectedTransactionType == TransactionType.Deposit)
            {
                query = query.Where(r => r.Amount >= 0);
            }
            if (svm.SelectedTransactionType == TransactionType.Withdraw)
            {
                query = query.Where(r => r.Amount <= 0);
            }
            if (svm.SelectedTransactionType == TransactionType.Fee)
            {
                //TODO: how do we know if a transaction is a fee? Ignore next line, just dummy code
                query = query.Where(r => r.Amount <= 20);
                //Bonuses???
            }
            if (svm.MinAmount != null && svm.MinAmount != 0)
            {
                query = query.Where(r => r.Amount >= svm.MinAmount);
            }
            if (svm.MaxAmount != null && svm.MaxAmount != 0)
            {
                query = query.Where(r => r.Amount <= svm.MaxAmount);
            }

            if (svm.TransactionId != null)  //(svm.Title != null && svm.Title != "")
            {
                query = query.Where(r => r.TransactionID == svm.TransactionId);
            }
            if (svm.EarliestDate != null)
            {
                query = query.Where(r => r.DisputeDate >= svm.EarliestDate);
            }
            if (svm.LatestDate != null)
            {
                query = query.Where(r => r.DisputeDate <= svm.LatestDate);
            }

            //List<Repository> SelectedRepositories = query.Include(r => r.Language).ToList();

            List<Transaction> SelectedTransactions = query.ToList();
            ViewBag.AllTransactions = _context.Transactions.Count();

            ViewBag.SelectedTransactions = SelectedTransactions.Count();

            if (svm.SelectedSortBy == SortBy.TransactionNumber && svm.SelectedSort == Sort.Ascending)
            {
                return View("DisplaySearchResults", SelectedTransactions.OrderBy(r => r.TransactionID));
            }
            if (svm.SelectedSortBy == SortBy.TransactionNumber && svm.SelectedSort == Sort.Descending)
            {
                return View("DisplaySearchResults", SelectedTransactions.OrderByDescending(r => r.TransactionID));
            }


            if (svm.SelectedSortBy == SortBy.Type && svm.SelectedSort == Sort.Ascending)
            {
                return View("DisplaySearchResults", SelectedTransactions.OrderBy(r => r.TransactionType));
            }
            if (svm.SelectedSortBy == SortBy.Type && svm.SelectedSort == Sort.Descending)
            {
                return View("DisplaySearchResults", SelectedTransactions.OrderByDescending(r => r.TransactionType));
            }


            if (svm.SelectedSortBy == SortBy.Description && svm.SelectedSort == Sort.Ascending)
            {
                return View("DisplaySearchResults", SelectedTransactions.OrderBy(r => r.TransactionComments));
            }
            if (svm.SelectedSortBy == SortBy.Description && svm.SelectedSort == Sort.Descending)
            {
                return View("DisplaySearchResults", SelectedTransactions.OrderByDescending(r => r.TransactionComments));
            }
            if (svm.SelectedSortBy == SortBy.Amount && svm.SelectedSort == Sort.Ascending)
            {
                return View("DisplaySearchResults", SelectedTransactions.OrderBy(r => r.Amount));
            }
            if (svm.SelectedSortBy == SortBy.Amount && svm.SelectedSort == Sort.Descending)
            {
                return View("DisplaySearchResults", SelectedTransactions.OrderByDescending(r => r.Amount));
            }
            if (svm.SelectedSortBy == SortBy.Date && svm.SelectedSort == Sort.Ascending)
            {
                //String var = Transaction.SortBy.Type;
                return View("DisplaySearchResults", SelectedTransactions.OrderBy(r => r.DisputeDate));
            }
            if (svm.SelectedSortBy == SortBy.Date && svm.SelectedSort == Sort.Descending)
            {
                //String var = Transaction.SortBy.Type;
                return View("DisplaySearchResults", SelectedTransactions.OrderByDescending(r => r.DisputeDate));
            }


            return View("DisplaySearchResults", SelectedTransactions.OrderByDescending(r => r.Amount));


            //TODO: use viewbag, pass into new variable, and add that into above line

        }
    }
}
