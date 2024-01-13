using ClassesAbstratas.Entities;
using System.Globalization;

namespace ClassesAbstratas
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Account> alist = new List<Account>();

            alist.Add(new SavingsAccount(1001, "Alex", 500.0, 0.01));
            alist.Add(new BusinessAccount(1002, "Maria", 500.0, 400.0));
            alist.Add(new SavingsAccount(1003, "Bob", 500.0, 0.01));
            alist.Add(new BusinessAccount(1004, "Anna", 500.0, 500.0));

            double sum = 0.0;
            foreach (Account acc  in alist)
            {
                sum += acc.Balance;
            }

            Console.WriteLine("Total balance: " + sum.ToString("F2",CultureInfo.InvariantCulture));

            foreach (Account acc in alist)
            {
                acc.Withdraw(10.0);
            }

            foreach (Account acc in alist)
            {
                Console.WriteLine("Update balance for accounts "
                    + acc.Number
                    + ": "
                    + acc.Balance.ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}