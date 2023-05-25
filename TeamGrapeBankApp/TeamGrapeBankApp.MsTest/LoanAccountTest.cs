using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace TeamGrapeBankApp.MsTest
{
    [TestClass]
    public class LoanAccountTest
    {
        [TestMethod]
        public void LoanLimit_ShouldNotGoOverLimit()
        {
            //Arrange
            List<BankAccount> bankAccounts = new List<BankAccount>();
            User ste = new Customer(5, "Affe", "lol1337", "Alfred", "Larsson", "Tågvägen 4C", "affe@hotmail.com", "0790114350", false);
            BankAccount pew = new BankAccount("Games", "13371337", "Affe", "SEK", 10000m);
            bankAccounts.Add(pew);
            
            //Act
            decimal actual = LoanAccount.LoanLimit(ste, bankAccounts);
            decimal expected = 50000m;

            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
