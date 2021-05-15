using System.Collections.Generic;
using ParMath.Class;

namespace ParMath.Interface
{
    public interface IUser
    {
        string Username { get; set; }
        string Password { get; set; }
        int TotalGames { get; set; }
        int CupsLoses { get; set; }
        int CupsWins { get; set; }
        List<Tournament> CurrentTournament { get; set; }
    }
}