using System;
using System.Collections.Generic;
using System.Text;

namespace homework
{
    public class Game
    {
        public Team Team1 { get; set; }
        public Team Team2 { get; set; }
        public Referee Referee { get; set; }
        public List<Referee> AssistantReferees { get; set; } = new List<Referee>();
        public string GameResult { get; set; }
        public Team Winner { get; set; }
    }
}
