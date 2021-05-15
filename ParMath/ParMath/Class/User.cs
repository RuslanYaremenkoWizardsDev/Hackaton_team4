using ParMath.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParMath.Class
{
    public class User : IUser
    {
        public string Username
        {
            get => Username;
            set
            {
                if (value.Length <= 3 || value.Length >= 255)
                {
                    throw new ArgumentException("Error: username most be ragne 4..255 simbol.");
                }
                else
                {
                    value = value.Replace(" ", "");
                    Username = value;
                }
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
            }
        }
        public int TotalGames { get; set; }
        public int CupsLoses { get; set; }
        public int CupsWins { get; set; }
        public List<Tournament> CurrentTurnament { get; set; }

        public User(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
