using ParMath.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParMath.Interface
{
    interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        int TotalGames { get; set; }
        int CupsLoses { get; set; }
        int CupsWins { get; set; }
        List<Tournament> CurrentTurnament { get; set; }
    }
}
