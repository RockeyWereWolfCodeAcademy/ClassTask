using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassTask
{
    public class User
    {
        public string Username;
        public string Password;
        public bool IsLoggedIn;

        public User(string username, string password)
        {
            Username = username;
            Password = password;
            IsLoggedIn = false;
        }

        public void Login(string username, string password)
        {
            if (IsLoggedIn)
            {
                Console.WriteLine($"User {Username} already logged in.");
            }
            else if (Username == username && Password == password)
            {
                IsLoggedIn = true;
                Console.WriteLine($"User {Username} is logged into the account.");
            }
            else
            {
                Console.WriteLine("Invalid username or password.");
            }
        }

        public void Logout()
        {
            if (IsLoggedIn)
            {
                IsLoggedIn = false;
                Console.WriteLine($"User {Username} logged out.");
            }
            else
            {
                Console.WriteLine($"User {Username} is not logged in.");
            }
        }
    }
}
