using System;

namespace BankAccount
{
    public class BankAccount: IBankAccount
    {
        const int maxWithDrawal = 10000;

        static int accountNumber = 0;
        int balance;

        bool isAllowedMaxOut = false;

        public BankAccount(bool AllowedMaxout)
        {
            accountNumber++;
            isAllowedMaxOut = AllowedMaxout;
        }
        public int GetAccountNumber() { return accountNumber; }
        public int GetBalance() { return balance; }
        public void Deposit(int deposit) { balance += deposit; }
        public void WithDraw(int withDraw)
        {
            if ((withDraw > balance) && !isAllowedMaxOut)
            {
                throw new Exception("Balance Too Low!");
            }
            else if ((withDraw > maxWithDrawal) && !isAllowedMaxOut)
            {
                throw new Exception("Thats Too Much!");
            }
            else
            {
                balance -= withDraw;
                Console.WriteLine("Thank you Enjoy!\nPrinting updated info for account: " );
                PrintInfo();
            }
            
        }
        public void PrintInfo()
        {
            Console.Write(" Account Number: " + GetAccountNumber() + "\n" +
                                 "\tBalance: " + GetBalance());
            Console.WriteLine();
        }
    }
}
