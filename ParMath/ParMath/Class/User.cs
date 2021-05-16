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
        
        public string Username
        {
            get
            {
                return _username;
            }
            set
            {
                if (value.Length > 3 || value.Length < 255)
                {
                     value = value.Replace(" ", "");
                    _username = value;
                }
                else
                {
                    throw new ArgumentException("Error: username most be ragne 4..255 simbol.");
                }
            }
        }

        public string Password
        {
            get
            {
                return _password;
            }
            set
            {
                if (value.Length < 6 || value.Length >= 255)
                {
                    throw new ArgumentException("Error: password most be ragre 6..255");
                }

                _password = value;
            }
        }



        public User(string username, string password)
        {
            if (username.Length <= 3 || username.Length >= 255)
            {
                throw new ArgumentException("Error: username most be ragne 4..255 simbol.");
            }
            else
            {
                Username = username;
            }

            if (password.Length < 6 || password.Length >= 255)
            {
                throw new ArgumentException("Error: password most be include");
            }
            else
            {
                password = password.Replace(" ", "");
                Password = password;
            }
        }
    }
}