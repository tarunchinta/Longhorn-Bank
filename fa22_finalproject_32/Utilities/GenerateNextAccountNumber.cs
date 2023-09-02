using fa22_finalproject_32.DAL;
using System;
using System.Linq;

namespace fa22_finalproject_32.Utilities
{
    public class GenerateNextAccountNumber
    {
        public static String GetNextAccountNumber(AppDbContext _context)
        {
            const UInt32 START_NUMBER = 2290000000;

            UInt32 intMaxAccountNumber; 
            UInt32 intNextAccountNumber; 

            if (_context.Accounts.Count() == 0) 
            {
                intMaxAccountNumber = START_NUMBER; 
            }
            else
            {
                intMaxAccountNumber = UInt32.Parse(_context.Accounts.Max(c => c.AccountNumber));
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 2290000000 
            //in the database
            if (intMaxAccountNumber < START_NUMBER)
            {
                intMaxAccountNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextAccountNumber = intMaxAccountNumber + 1;

            //return the value
            return intNextAccountNumber.ToString();
        }
    }
}
