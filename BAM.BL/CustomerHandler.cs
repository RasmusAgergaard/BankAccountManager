using System;
using System.Collections.Generic;
using System.Text;

namespace BAM.BL
{
    public class CustomerHandler
    {
        public CustomerHandler()
        {
        }

        public bool EditCustomer(int customerId)
        {
            return true;
        }

        public bool Deposit(int customerId)
        {
            return true;
        }

        public bool Withdraw(int customerId)
        {
            return true;
        }

        public Customer CreateCustomer(string firstName, string lastName, string email, string phoneNumber)
        {
            //Create a new customer with a unique id
            var guid = Guid.NewGuid().ToString();

            Customer customer = new Customer(guid);

            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Email = email;
            customer.PhoneNumber = phoneNumber;

            return customer;
        }
    }
}
