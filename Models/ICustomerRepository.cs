using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace simple_injector_mvc.Models
{
    public interface ICustomerRepository
    {
        List<Customer> GetCustomers();
    }
}
