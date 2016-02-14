using System.Web.Mvc;
using simple_injector_mvc.Models;

namespace simple_injector_mvc.Controllers
{
    public class CustomerController : Controller
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerController(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        // GET: Customer
        public ActionResult Index()
        {
            var customer = _customerRepository.GetCustomers();
            return View(customer);
        }
    }
}