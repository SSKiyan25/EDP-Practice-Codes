using SteamReplica.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamReplica.Classes
{
    public class CompanySeller
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public List<Game> Games;

        public CompanySeller()
        {
            this.Games = new List<Game>();
            this.Name = string.Empty;
            this.Description = string.Empty;
        }

        public void addGame(Game game)
        { this.Games.Add(game); }
        public override string ToString()
        {
            string display = "\n";
            display += this.Name;
            foreach (Game game in this.Games) 
            {
                display += "\n" + game.ToString();
            }
            display += "\n";
            return display;
        }
    }
}
