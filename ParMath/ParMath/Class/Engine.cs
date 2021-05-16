using System;
using System.Collections.Generic;

namespace ParMath.Class
{
    public class Engine
    {
        public Dictionary<string, string> AllUser = new Dictionary<string, string>();
        public List<User> Users = new List<User>();

        public void AddToDictionary(User currentUser)
        {
            AllUser.Add(currentUser.Username, currentUser.Password);
        }

        public bool FindInDictionary(string username, string password)
        {
            bool isExist = false;
            foreach (KeyValuePair<string, string> entry in AllUser)
            {
                if (username == entry.Key)
                {
                    if (password == entry.Value)
                    {
                        isExist = true;
                    }
                }
            }
            return isExist;
        }
    }
}