using System;

namespace BAM.BL
{
    public class Customer
    {
        public enum State { Active, Locked, Deactive };

        public Customer(int customerId)
        {
            CustomerId = customerId;
            state = State.Active;
        }

        public int CustomerId { get; private set; }
        public State state { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
    }
}
