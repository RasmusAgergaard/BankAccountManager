using System;
using BAM.BL;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BAM.BL_Test
{
    [TestClass]
    public class CustomerHandlerTest
    {
        [TestMethod]
        public void CreateAndSetCustomerTest()
        {
            //Arrange
            CustomerHandler customerHandler = new CustomerHandler();
            var customer = customerHandler.CreateCustomer();

            //Act
            customer = customerHandler.SetCustomerInfomation(customer, "Lars", "Hansen", "test@email.dk", "45454545");

            //Assert
            Assert.AreNotEqual(customer.CustomerId, 0);
            Assert.AreEqual(customer.state.ToString(), "Active");
            Assert.AreEqual(customer.FirstName, "Lars");
            Assert.AreEqual(customer.LastName, "Hansen");
            Assert.AreEqual(customer.Email, "test@email.dk");
            Assert.AreEqual(customer.PhoneNumber, "45454545");
        }
    }
}
