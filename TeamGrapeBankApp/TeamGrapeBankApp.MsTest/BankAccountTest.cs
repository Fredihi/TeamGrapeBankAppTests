using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeamGrapeBankApp.MsTest
{
    [TestClass]
    public class BankAccountTest
    {
        [TestMethod]
        public void InternalTransaction_ShouldTransferMoneyFromOneAccountToTheOther()
        {
            //Arrange
            List<BankAccount> bankAccounts = new List<BankAccount>();
            List<User> cus = new List<User>();
            User testUser = new Customer(5, "Affe", "pass1", "Bill", "Gates", "Nygatan 26 31176 Falkenberg", "bill@microsoft.se", "+46702222222", false);
            BankAccount testAccount = new BankAccount("Vacation", "3005-3135", "Affe", "SEK", 1000000m);
            BankAccount testAccount2 = new BankAccount("Salary Account", "1337-3341", "Affe", "SEK", 50000m);
            
            cus.Add(testUser);
            bankAccounts.Add(testAccount);
            bankAccounts.Add(testAccount2);


            var FromAccountBeforeTransfer = testAccount.Balance;
            var ToAccountBeforeTransfer = testAccount2.Balance;
            //Act
            BankAccount.InternalTransaction("Affe", testAccount, testAccount2, 50000m);


            //Assert
            Assert.AreNotEqual(FromAccountBeforeTransfer, testAccount.Balance);
            Assert.AreNotEqual(ToAccountBeforeTransfer, testAccount2.Balance);

        }
    }
}
