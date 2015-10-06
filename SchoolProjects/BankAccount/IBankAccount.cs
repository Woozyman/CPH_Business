using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    public interface IBankAccount
    {
        int GetAccountNumber();
        int GetBalance();
        void Deposit(int deposit);
        void WithDraw(int withDraw);
        void PrintInfo();

    }
}
