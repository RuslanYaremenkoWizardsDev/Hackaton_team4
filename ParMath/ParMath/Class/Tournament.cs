using static ParMath.Class.MyEnum;
using ParMath.Interface;
using System;
using System.Collections.Generic;

namespace ParMath.Class
{


    public class Tournament : ITournament
    {

        public string NameTournament { get; set; }
        public string Description { get; set; }
        public string StartDate { get; set; }
        public string LastRegistDate { get; set; }
        public string Place { get; set; }
        public int Partiseted { get; set; }
        public Level Level { get; set; }
        public Scenari Scenary { get; set; }
        public State State { get; set; }
    }
}