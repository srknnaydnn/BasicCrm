using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Business.Abscrate;
using Business.Concrete;
using Entities;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers
{
    [Authorize]
    public class Customer : Controller
    {
        private ICustomerServices customerServices;
        public Customer()
        {
            customerServices = new CustomerManger();
        }
        
        public IActionResult Index()
        {
            var customers = customerServices.GetAllCustomer();
            
            return View(customers);
        }

        [HttpGet]
        public IActionResult CustomerAdd()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CustomerAdd(Customers customer)
        {
            if (ModelState.IsValid)
            {
              var add = customerServices.CreateCustomer(customer);
                return RedirectToAction("Index");
            }
              
            return View();
        }
        public IActionResult CustomerDelete(int id)
        {
            customerServices.DeleteCustomer(id);
            return RedirectToAction("Index");
        }
        public IActionResult CustomerDetail(int id)
        {
            var find = customerServices.GetCustomerById(id);
            var viewModel = new Customers()
            {
                Tc = find.Tc,
                Name = find.Name,
                Surname = find.Surname,
                Telefone = find.Telefone,
                Adress = find.Adress,
                City = find.City

            };

            return View(viewModel);
        }
        public IActionResult CustomerFind(int id)
        {
            var find=customerServices.GetCustomerById(id);
           
            return View("CustomerFind",find);
        }
        public IActionResult CustomerUpdate(Customers customer)
        {
            if (ModelState.IsValid)
            {
               customerServices.UpdateCustomer(customer);
                return RedirectToAction("Index");
            }
            return View("Index");
        }
      
    }
}
