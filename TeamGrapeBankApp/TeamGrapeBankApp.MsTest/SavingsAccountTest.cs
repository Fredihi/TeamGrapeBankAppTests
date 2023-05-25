using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TeamGrapeBankApp.MsTest
{
    [TestClass]
    public class SavingsAccountTest
    {
        [TestMethod]
        public void OpenNewSavingsAccount_ShouldOpenANewSavingsAccount()
        {
            //Arrange
            List<SavingsAccount> savingsAccountsTest = new List<SavingsAccount>();
            Dictionary<int, decimal> savingsDict = new Dictionary<int, decimal>() { {12, 1.0150m }, {6, 1.0050m } };
            User loggedInCustomer = new Customer(5, "billgates", "pass1", "Bill", "Gates", "Nygatan 26 31176 Falkenberg", "bill@microsoft.se", "+46702222222", false);
            string accountName = "TestSavingsAccount";
            string accountNumber = "13371337";
            string userInputCurrency = "SEK";
            decimal userInputAmount = 5000;
            int userInputType = 12;

            var newSavings = new SavingsAccount(accountName, accountNumber, loggedInCustomer.Username, userInputCurrency, userInputAmount, savingsDict[userInputType]);

            //Act
            savingsAccountsTest.Add(newSavings);

            //Assert
            CollectionAssert.Contains(savingsAccountsTest, newSavings);
        }
    }
}
