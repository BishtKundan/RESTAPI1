using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RESTAPI1.Model;

namespace RESTAPI1.Controllers
{
    [Route("api/[controller]")]
    [ApiController] 
    public class AccountsController : ControllerBase
    {
        [HttpGet]
        public IEnumerable<Account> Get()
        {
            return new List<Account>
            {
                new Account{ AccountNumber="0001", BankName="Dummy Bank", CustomerAddress= new Address
                {
                     Address1="address1", Address2="address2", Country="US", PostalCode="20877", State="MD"
                }, CustomerId="Customer001", CustomerName="John Sherman"
                },  new Account{ AccountNumber="0002", BankName="Dummy Bank", CustomerAddress= new Address
                {
                     Address1="address3", Address2="address4", Country="US", PostalCode="20877", State="MD"
                }, CustomerId="Customer002", CustomerName="Marie Curie"
                }
            };
        }

        [HttpGet("{acctNumber}")]
        public Account Get(string acctNumber)
        {
            return new Account
            {
                AccountNumber = "0001",
                BankName = "Dummy Bank",
                CustomerAddress = new Address
                {
                    Address1 = "address1",
                    Address2 = "address2",
                    Country = "US",
                    PostalCode = "20877",
                    State = "MD"
                },
                CustomerId = "Customer001",
                CustomerName = "John Sherman"
            };
        }

        [HttpPost]
        public ActionResult Post([FromBody]Account account)
        {
            return Created(Request.QueryString.Value, account);
        }

        [HttpPut("{acctNumber}")]
        public ActionResult Put(string acctNumber,
        [FromBody]string account)
        {
            return Ok("Account with account number: " + acctNumber + " has been updated!");
        }




    }
}