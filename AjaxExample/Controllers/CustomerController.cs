using AjaxExample.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AjaxExample.Controllers
{
    public class CustomerController : Controller
    {
        List<CustomerModel> customers = new List<CustomerModel>();

        public CustomerController()
        {
            customers.Add(new CustomerModel { Id = 0, Name = "Maciej", Age = 35 });
            customers.Add(new CustomerModel { Id = 1, Name = "Magda", Age = 30 });
            customers.Add(new CustomerModel { Id = 2, Name = "Skiper", Age = 25 });
            customers.Add(new CustomerModel { Id = 3, Name = "Tomasz", Age = 15 });
            customers.Add(new CustomerModel { Id = 4, Name = "Kinga", Age = 32 });
        }

        public IActionResult Index()
        {
            return View(customers);
        }

        public IActionResult ShowOnePerson(int Id)
        {
            CustomerModel c = customers.FirstOrDefault(x => x.Id == Id);
            return PartialView(c);
        }


    }
}
