using System;
using System.Collections.Generic;
using System.Text;

namespace BAM.BL
{
    public class CustomerHandler
    {
        public CustomerHandler()
        {
            UniqueCustomerId = 1;
        }

        public static int UniqueCustomerId { get; private set;}

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

        public Customer CreateCustomer()
        {
            //Create a new customer with a unique id
            Customer customer = new Customer(UniqueCustomerId);

            //Increase unique id
            UniqueCustomerId += 1;

            return customer;
        }

        public Customer SetCustomerInfomation(Customer customer, string firstName, string lastName, string email, string phoneNumber)
        {
            customer.FirstName = firstName;
            customer.LastName = lastName;
            customer.Email = email;
            customer.PhoneNumber = phoneNumber;

            return customer;
        }

    }
}
