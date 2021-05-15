using ParMath.Interface;
using System;
using System.Collections.Generic;

namespace ParMath.Class
{
    public class User : IUser
    {
        public int TotalGames { get; set; }
        public int CupsLoses { get; set; }
        public int CupsWins { get; set; }
        public List<Tournament> CurrentTournament { get; set; }
        
        public string Username
        {
            get => Username;
            set
            {
                if (value.Length <= 3 || value.Length >= 255)
                {
                    throw new ArgumentException("Error: username most be ragne 4..255 simbol.");
                }

                value = value.Replace(" ", "");
                Username = value;
            }
        }

        public string Password
        {
            get => Password;
            set
            {
                if (value.Length < 6 || value.Length >= 255)
                {
                    throw new ArgumentException("Error: password most be ragre 6..255");
                }
                
                Password = value;
            }
        }



        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}