using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal class Bank : IBanking
    {
        private int _balance;
        public void deposit(int amount)
        {
            _balance+= amount;
        }

        public void getAccountDetails(int accountId)
        {
            Console.WriteLine("account details are displayed");
        }
        public int getBalance()
        {
            return _balance;
        }

        public void withdraw(int amount)
        {
            if(_balance>amount)
            {
                _balance -= amount;
            }
            else
            {
                Console.WriteLine("Can't withdraw");
            }
        }
    }
}
