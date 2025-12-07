using GameConsole.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameConsole.Data
{
    internal class UserDb
    {
        private static List<User> users;

        public UserDb()
        {
            users = new List<User>();
        }
        public static User RegisterUser(string username, string name, string password)
        { 
            User newUser = new User(username, name, password);
            users.Add(newUser);
            return newUser;
        }

        public static User Login(string username, string password)
        {
            foreach (User user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    return user;
                }
            }
            return null;
        }

        public static void Update(User user)
        {
            foreach (User u in users)
            {
                if (u.Username == user.Username)
                {
                    u.Name = user.Name;
                    u.Password = user.Password;
                    return;
                }
            }

            throw new InvalidOperationException("no such user exists");
        }
    }
}
