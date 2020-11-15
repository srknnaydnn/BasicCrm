using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abscrate
{
    public interface ICustomerRepository
    {
        List<Customers> GetAllCustomers();

        Customers GetCustomerById(int id);

        Customers CreateCustomer(Customers customer);
        Customers UpdateCustomer(Customers customer);
        void DeleteCustomer(int id);
    }
}
