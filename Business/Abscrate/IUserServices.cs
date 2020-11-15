using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Abscrate
{
    public interface IUserServices
    {
        Users CreateUser(Users user);
        Users UserById(Users user);

    }
}
