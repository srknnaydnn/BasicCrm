using DataAccess.Abscrate;
using Entities;
using fm.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace DataAccess.Concrete
{

    public class CustomerRepository : ICustomerRepository
    {
        

        public Customers CreateCustomer(Customers customer)
        {

            using (var _dbContext = new CustomerDbContext())
            {
                _dbContext.Database.ExecuteSqlRaw("spCustomerAdd {0},{1},{2},{3},{4},{5}",
                      customer.Tc, customer.Name, customer.Surname, customer.Telefone, customer.Adress, customer.City);

                return customer;
            }
        }

        public void DeleteCustomer(int id)
        {
            using (var _dbContext = new CustomerDbContext())
            {

                _dbContext.Database.ExecuteSqlRaw($"spCustomerDelete {id}");

            }
        }

        public List<Customers> GetAllCustomers()
        {
            using (var _dbContext = new CustomerDbContext())
            {
                return _dbContext.Customers.FromSqlRaw<Customers>("spCustomerGetAll").ToList();
            }
        }

        public Customers GetCustomerById(int id)
        {
            using (var _dbContext = new CustomerDbContext())
            {
                return _dbContext.Customers.FromSqlRaw<Customers>($"spCustomerGetByID {id}").ToList().FirstOrDefault();

            }


        }

            public Customers UpdateCustomer(Customers customer)
            {
                using (var _dbContext = new CustomerDbContext())

                _dbContext.Database.ExecuteSqlRaw("spCustomerUpdate {0},{1},{2},{3},{4},{5},{6}",
                     customer.Id,customer.Tc,customer.Name,customer.Surname,customer.Telefone,customer.Adress,customer.City);

                    return customer;
                }
            }
        }
     

