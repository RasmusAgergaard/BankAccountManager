using System;
using System.Collections.Generic;
using System.Text;

namespace BAM.BL
{
    public class CustomerHandler
    {
        public int UniqueCustomerId { get; set; }

        public Customer CreateCustomer(string customerName)
        {
            Customer customer = new Customer();

            return customer;
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
    }
}
