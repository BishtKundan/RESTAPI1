using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTAPI1.Model
{
    public class Account
    {
        public string AccountNumber { get; set; }
        public string CustomerId { get; set; }
        public string BankName { get; set; }
        public string CustomerName { get; set; }
        public Address CustomerAddress
        {
            get; set;
        }
    }


    public class Address
    {
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string PostalCode { get; set; }
        public string State { get; set; }
        public string Country { get; set; }
    }
}
