using System;
using System.Collections.Generic;

namespace ParMath.Class
{
    public class Engine
    {
        public Dictionary<string, string> AllUser = new Dictionary<string, string>();

        public void AddToDictionary(User currentUser)
        {
            AllUser.Add(currentUser.Username, currentUser.Password);
        }

        public void FindInDictionary(string username, string password)
        {
            foreach (KeyValuePair<string, string> entry in AllUser)
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