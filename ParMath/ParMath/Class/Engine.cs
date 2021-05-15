using System;
using System.Collections.Generic;

namespace ParMath.Class
{
    public class Engine
    {
        private Dictionary<string, string> allUser = new Dictionary<string, string>();

        public void AddToDictionary(User currentUser)
        {
            allUser.Add(currentUser.Username, currentUser.Password);
        }

        public void FindInDictionary(string username, string password)
        {
            foreach (KeyValuePair<string, string> entry in allUser)
            {
                if (username == entry.Key)
                {
                    if (password == entry.Value)
                    {
                        break;
                    }
                    throw new ArgumentException("Error: Password not find");
                }
                throw new AggregateException("Error: UserName not find");
            }
        }
    }
}