using bt3.Bank;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bt3
{
    public class Program
    {
        static void Main(string[] args)
        {
            BankAccount account = new BankAccount(1000000);

            account.BalanceChanged += Account_BalanceChanged;

            Console.WriteLine($"Current Balance: {account.Balance}");

            account.Deposit(500000);
            account.Withdraw(200000);

            Console.WriteLine($"Updated Balance: {account.Balance}");
        }

        private static void Account_BalanceChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Balance has been changed.");
        }
    }
}
