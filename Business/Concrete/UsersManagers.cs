using Business.Abscrate;
using DataAccess.Abscrate;
using DataAccess.Concrete;
using Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Business.Concrete
{
    public class UsersManagers : IUserServices
    {
        private IUserRepository  userRepository;
        public UsersManagers()
        {
            userRepository = new UserRepository();
        }

        public Users CreateUser(Users user)
        {
            return userRepository.CreateUser(user);
        }

        public Users UserById(Users users)
        {

            return userRepository.UserById(users);
        }
    }
}
