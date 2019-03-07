using System;

namespace BAM.BL
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public Name CustomerName { get; set; }
        public ContactInformation CustomerContactInformation { get; set; }
        //public enum State { get; set; }
        public Account CustomerAccount { get; set; }
    }
}
