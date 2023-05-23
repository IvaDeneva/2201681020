using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Team  
    {
        public Coach coach { get; set; }
        public List<FootballPlayer> players { get; set; } = new List<FootballPlayer>();
        public double avrgAgeOfPlayers { get; set; }
 
    }
}
