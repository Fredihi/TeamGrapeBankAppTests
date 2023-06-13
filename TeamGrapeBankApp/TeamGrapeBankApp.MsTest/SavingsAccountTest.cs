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
        public void ReturnYearlyInterest_ShouldReturnInterestForEveryYear()
        {
            //Arrange
            int months = 12;
            decimal amount = 10000m;
            
            //Act

            decimal actual = SavingsAccount.ReturnYearlyInterest(months, amount);
            decimal expected = 150;
            //Assert
            Assert.AreEqual(expected, actual);
        }
    }
}
