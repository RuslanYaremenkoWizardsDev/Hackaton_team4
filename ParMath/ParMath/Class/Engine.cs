using System;
using System.Collections.Generic;

namespace ParMath.Class
{
    public class Engine
    {
        public List<User> Users = new List<User>();

        public bool FindUser(string username, string password)
        {
            bool isExist = false;
            foreach (User user in Users)
            {
                if (user.Username == username)
                {
                    if (user.Password == password)
                    {
                        isExist = true;
                    } else
                    {
                        isExist = false;
                    }
                }
            }
            return isExist;
        }

        public void Seeds(int quantityUsers)
        {
            string defaultUsername = "Shaitan";
            string defaultPassword = "Password";
            for ( int i = 0; i  < quantityUsers; i++)
            {
                defaultUsername += i;
                defaultPassword += i;
                User user = User.CreateUser(defaultUsername, defaultPassword);
                Users.Add(user);
            }
        }
        public bool UniquelyUser(string username)
        {
            bool uniquely = true;
            foreach ( User user in Users)
            {
                if ( user.Username == username)
                {
                    uniquely = false;
                    break;
                }
            }
            return uniquely;
        }
    }
}