using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proxy
{
    internal interface IBanking
    {
        void deposit(int amount);
        void withdraw(int amount);
        void getAccountDetails(int accountId);
        int getBalance();
    }
}
