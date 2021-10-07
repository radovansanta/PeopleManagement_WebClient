using System;
using System.Collections.Generic;
using System.Linq;
using DNP_Assignment1.Persistence;
using Models;

namespace DNP_Assignment1.Data.Impl
{

    public class InMemoryUserService : IUserService
    {
        private List<User> users;

        public InMemoryUserService()
        {
            FileContext fileContext = new();
            users = fileContext.Users.ToList();
            Console.Out.WriteLine(users[0].Email);
        }

        public User ValidateUser(string email, string password)
        {
            FileContext fileContext = new();
            users = fileContext.Users.ToList();
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