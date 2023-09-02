using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using fa22_finalproject_32.DAL;
using fa22_finalproject_32.Models;
using static NuGet.Packaging.PackagingConstants;
using Microsoft.AspNetCore.Identity;
using fa22_finalproject_32.Utilities;
using Microsoft.AspNetCore.Authorization;

namespace fa22_finalproject_32.Controllers
{
    [Authorize]
    public class AccountsController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public AccountsController(AppDbContext context, UserManager<AppUser> userManger)
        {
            _context = context;
            _userManager = userManger;
        }

            // GET: Account
            public async Task<IActionResult> Index()
        {
            List<Account> Accounts = new List<Account>();
            Accounts = _context.Accounts.Where(o => o.AppUser.UserName == User.Identity.Name).Include(ord => ord.Transactions).ToList();

            return View(Accounts);
        }

        // GET: Account/Details/5
        public async Task<IActionResult> Details(long? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            Account account = _context.Accounts
                        .Include(ord => ord.Transactions).ThenInclude(ord => ord.Disputes)
                        .Include(ord => ord.AppUser)
                        .FirstOrDefault(o => o.AccountID == id);

            if (account == null)
            {
                return NotFound();
            }

            //make sure a customer isn't trying to look at someone else's account
            if (User.IsInRole("Admin") == false && account.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new string[] { "You are not authorized to view this account!" });
            }

            return View(account);
        }


        // GET: Accounts/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Account/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Account account, int depositAmount)
        {
            if (ModelState.IsValid == false)
            {
                return View();
            }

            // create new account
            account.AppUser = await _userManager.FindByNameAsync(User.Identity.Name);

            if (account.AccountName == "" || account.AccountName == null)
            {
                if (account.AccountType == AccountType.Checking)
                {
                    account.AccountName = "Longhorn Checking";
                }
                else if (account.AccountType == AccountType.Savings)
                {
                    account.AccountName = "Longhorn Savings";
                }
                else
                {
                    account.AccountName = "IRA";
                }
            }

            //IRA logics
            if (account.AccountType == AccountType.IRA)
            {
                int iras = _context.Accounts.Include(o => o.AppUser).Where(o => o.AppUser.Id == account.AppUser.Id && o.AccountType == AccountType.IRA).ToList().Count;
                if (iras != 0)
                {
                    return View("Error", new string[] { "You already have an IRA account!" });
                }
                if (depositAmount > 5000)
                {
                    return View("Error", new string[] { "You contribute over 5000 to an IRA account this year!" });
                }
                if (account.AppUser.Birthday.AddYears(70) > DateTime.Now)
                {
                    return View("Error", new string[] { "Customers who are over 70 years old are not allowed to contribute to an IRA account!" });
                }
            }

            account.AccountNumber = Utilities.GenerateNextAccountNumber.GetNextAccountNumber(_context);

            _context.Add(account);
            await _context.SaveChangesAsync();

            // create deposit transaction
            Transaction transaction = new Transaction();
            transaction.TransactionType = TransactionType.Deposit;
            transaction.DisputeDate = DateTime.Now;
            transaction.Amount = depositAmount;
            transaction.Account = account;
            transaction.User = account.AppUser.Email;

            //TODO: redirect to admin for approval if initial deposit is over 5000
            //if (transaction.Amount >= 5000)
            transaction.Approved = Approved.Yes;

            _context.Add(transaction);
            _context.SaveChanges();

            //return RedirectToAction("Create", "Transactions", new { accountID = account.AccountID });
            return RedirectToAction(nameof(Index));
        }

        // GET: Account/Edit/5
        public async Task<IActionResult> Edit(long? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            Account account = _context.Accounts
                                        .Include(r => r.Transactions)
                                        .ThenInclude(r => r.Disputes)
                                        .Include(r => r.AppUser)
                                        .FirstOrDefault(r => r.AccountID == id);

            if (account == null)
            {
                return NotFound();
            }

            if (User.IsInRole("Customer") && account.AppUser.UserName != User.Identity.Name)
            {
                return View("Error", new String[] { "You are not authorized to edit this account!" });
            }

            return View(account);
        }

        // POST: Account/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(long id, Account account)
        {
            if (id != account.AccountID)
            {
                return View("Error", new String[] { "There was a problem editing this account. Try again!" });
            }

            //if there is something wrong with this order, try again
            if (ModelState.IsValid == false)
            {
                return View(account);
            }

            //if code gets this far, update the record
            try
            {
                //find the record in the database
                Account dbAccount = _context.Accounts.Find(account.AccountID);

                //update
                dbAccount.AccountName = account.AccountName;

                _context.Update(dbAccount);
                await _context.SaveChangesAsync();
            }
            catch (Exception ex)
            {
                return View("Error", new String[] { "There was an error updating this orderaccount!", ex.Message });
            }

            return RedirectToAction(nameof(Index));
        }

        // GET: Account/Delete/5
        public async Task<IActionResult> Delete(long? id)
        {
            if (id == null || _context.Accounts == null)
            {
                return NotFound();
            }

            var account = await _context.Accounts
                .FirstOrDefaultAsync(m => m.AccountID == id);
            if (account == null)
            {
                return NotFound();
            }

            return View(account);
        }

        // POST: Account/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(long id)
        {
            if (_context.Accounts == null)
            {
                return Problem("Entity set 'AppDbContext.Accounts'  is null.");
            }
            var account = await _context.Accounts.FindAsync(id);
            if (account != null)
            {
                _context.Accounts.Remove(account);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool AccountExists(long id)
        {
            return _context.Accounts.Any(e => e.AccountID == id);
        }
    }
}