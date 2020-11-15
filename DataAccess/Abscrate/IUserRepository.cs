using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataAccess.Abscrate
{
   public  interface IUserRepository
    {
        Users CreateUser(Users user);
        Users UserById(Users user);
    }
}
