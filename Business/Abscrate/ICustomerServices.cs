using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abscrate
{
    public interface ICustomerServices
    {
        List<Customers> GetAllCustomer();
        
        Customers GetCustomerById(int id);

        Customers CreateCustomer(Customers customer);
        Customers UpdateCustomer(Customers customer);
        void DeleteCustomer(int id);
    }
}
