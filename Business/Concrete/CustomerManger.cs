using Business.Abscrate;
using DataAccess.Abscrate;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class CustomerManger : ICustomerServices
    {
        private ICustomerRepository customerRepository;
        public CustomerManger()
        {
            
            customerRepository = new CustomerRepository();
        }
        public Customers CreateCustomer(Customers customer)
        {
           
            return customerRepository.CreateCustomer(customer);
        }

        public void DeleteCustomer(int id)
        {
            customerRepository.DeleteCustomer(id);
        }

        public List<Customers> GetAllCustomer()
        {
            return customerRepository.GetAllCustomers();
        }

        public Customers GetCustomerById(int id)
        {
            return customerRepository.GetCustomerById(id);
        }

        public Customers UpdateCustomer(Customers customer)
        {

          return customerRepository.UpdateCustomer(customer);
        }
    }
}
