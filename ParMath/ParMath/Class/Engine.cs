using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

namespace ParMath.Class
{
    public class Engine
    {
        private static Engine _engine;
        public List<User> Users;
        public List<Tournament> Tournaments;
        public User CurrentUser { get; set; }
        private Engine()
        {
            Users = new List<User>();
        }

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
                        CurrentUser = user;
                    } else
                    {
                        isExist = false;
                    }
                }
            }
            return isExist;
        }
        public static Engine GetEngine()
        {
           if(_engine is null)
            {
                _engine = new Engine();
            }
            return _engine;
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
        public void DeserializerUsers()
        {
            string fileContent = string.Empty;
            using (StreamReader sr = new StreamReader("Users.txt"))
            {
                fileContent = sr.ReadToEnd();
            }
            Users = JsonConvert.DeserializeObject<List<User>>(fileContent);
        }

        public void SaveAllUsers()
        {
            using (StreamWriter sw = new StreamWriter("Users.txt"))
            {
                sw.Write(JsonConvert.SerializeObject(Users));
            }
        }
    }
}