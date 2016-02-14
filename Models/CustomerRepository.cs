using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace simple_injector_mvc.Models
{
    public class CustomerRepository : ICustomerRepository
    {
        public List<Customer> GetCustomers()
        {
            var customers = new List<Customer>
            {
                new Customer{ Id=1, FirstName = "Jalpesh", LastName = "Vadgama"},
                new Customer{ Id=2, FirstName = "Vishal", LastName = "Vadgama"}
            };

            return customers;
        }
    }
}