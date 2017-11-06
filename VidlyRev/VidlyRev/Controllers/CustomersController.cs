using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using VidlyRev.Models;
using VidlyRev.ViewModels;

namespace VidlyRev.Controllers
{
    public class CustomersController : Controller
    {
        CustomersViewModel customersViewModel = new CustomersViewModel
        {
            Customers = new List<Customer>
            {
                new Customer { Id = 1, Name = "John Smith"},
                new Customer { Id = 2, Name = "Mary Williams"}
            }
        };
        // GET: Customers
        public ActionResult Index()
        {

            return View(customersViewModel);
        }

        public ActionResult Details(int id)
        {
            var customer = customersViewModel.Customers.SingleOrDefault(c => c.Id == id);

            return View(customer);
        }
    }
}