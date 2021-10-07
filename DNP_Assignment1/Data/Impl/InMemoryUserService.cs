using System;
using System.Collections.Generic;
using System.Linq;
using Models;

namespace DNP_Assignment1.Data.Impl
{

    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            users = new[]
            {
                new User()
                {
                    FisrtName = "Radovan",
                    LastName = "Santa",
                    Email = "santa.radovan@gmail.com",
                    SecurityLever = 1,
                    Password = "test"
                },
                new User()
                {
                    FisrtName = "Radovan",
                    LastName = "Santa",
                    Email = "santa.radovan@gmail.com",
                    SecurityLever = 1,
                    Password = "test"
                }
            }.ToList();


        }

        public User ValidateUser(string email, string password)
        {
            User user = users.FirstOrDefault(takenUser => takenUser.Email.Equals(email));

            if (user==null)
            {
                throw new Exception("User not found");
            }

            if (!user.Password.Equals(password))
            {
                throw new Exception("Incorrect password");
            }

            return user;
        }
    }
}