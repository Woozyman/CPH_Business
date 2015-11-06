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
