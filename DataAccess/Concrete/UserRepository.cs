using DataAccess.Abscrate;
using Entities;

using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Web.Mvc;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
       

        public Users UserById(Users users)
        {
            using (var customerDb = new CustomerDbContext())
            {
                customerDb.Users.FirstOrDefault(x=>x.Username==users.Username && x.Password==users.Password);
                
                return users;
                
            }     
                
            
        }

        Users IUserRepository.CreateUser(Users user)
        {
            using (var customerDb = new CustomerDbContext())
            {

                string name = Convert.ToString(user.ConfirmPassword);
                string mail = Convert.ToString(user.Email);
                string pass = Convert.ToString(user.Password);
                string confPass = Convert.ToString(user.ConfirmPassword);
                customerDb.Database.ExecuteSqlRaw("spCreateAdd {0},{1},{2},{3}",name, mail,pass, confPass);
            
                return user;
            }

        }
    }
}
