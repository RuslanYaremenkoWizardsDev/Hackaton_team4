using ParMath.Interface;
using System;
using System.Collections.Generic;

namespace ParMath.Class
{
    public class User : IUser
    {
        private string _username;
        private string _password;
        public int TotalGames { get; set; }
        public int CupsLoses { get; set; }
        public int CupsWins { get; set; }
        public List<Tournament> CurrentTournament { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        private User(string username, string password)
        {
                Username = username;

                password = password.Replace(" ", "");
                Password = password;
        }

        public static User CreateUser(string username, string password)
        {
            if ((username.Length >= 3 && username.Length <= 255) && (password.Length >= 6 && password.Length <= 255))
            {
                return new User(username, password);
            }

            return null;
        }
    }
}