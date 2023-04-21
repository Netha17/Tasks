using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class ATM : IBanking
    {
        private IBanking bank;
        public ATM()
        {
            if (bank == null)
            { 
            bank = new Bank();
            Console.WriteLine(bank);
            }
        }
        public void deposit(int amount)
        {
            bank.deposit(amount);
        }

        public void getAccountDetails(int accountId)
        {
            bank.getAccountDetails(accountId);
        }

        public void withdraw(int amount)
        {
            bank.withdraw(amount);
        }
        public int getBalance()
        {
            return bank.getBalance();
        }
    }
}
