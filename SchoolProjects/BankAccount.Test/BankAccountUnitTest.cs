using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BankAccount.Test
{
    [TestClass]
    public class BankAccountUnitTest
    {
        [TestMethod]
        public void DepositTest()
        {
            IBankAccount newAccount = new BankAccount(false);

            newAccount.Deposit(200);

            Assert.AreEqual(newAccount.GetBalance(), 200);
        }

        [TestMethod]
        public void MaxWithDrawalTest()
        {
            IBankAccount newAccount = new BankAccount(true);
            newAccount.Deposit(10001);
            newAccount.WithDraw(10002);

            Assert.AreEqual(newAccount.GetBalance(), -1);

        }

        [TestMethod]
        public void WithDrawalTest()
        {
            IBankAccount newAccount = new BankAccount(false);
            newAccount.Deposit(100);
            newAccount.WithDraw(90);

            Assert.AreEqual(newAccount.GetBalance(), 10);

        }
    }
}
