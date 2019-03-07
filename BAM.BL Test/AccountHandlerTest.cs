using System;
using BAM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BAM.BL_Test
{
    [TestClass]
    public class AccountHandlerTest
    {
        [TestMethod]
        public void CreateAccountTest()
        {
            //Arrange
            AccountHandler accountHandler = new AccountHandler();

            //Act
            var account = accountHandler.CreateAccount(1, "SavingsAccount");

            //Assert
            Assert.AreEqual(account.AccountId, 1);
            Assert.AreEqual(account.Type.ToString(), "SavingsAccount");
            Assert.AreEqual(account.State.ToString(), "Active");
            Assert.AreEqual(account.Balance, 0);

        }
    }
}
