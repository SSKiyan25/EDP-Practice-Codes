using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamReplica.Classes
{
    public class Customer
    {
        public string Name { get; set; }
        public double Balance { get; set; }
        
        public PaymentMethod? PaymentMethod { get; set; }
        public List<Game> Games;

        public Customer()
        {
            this.Name = string.Empty;
            this.Balance = 0.0;
            this.Games = new List<Game>();
        }

        public override string ToString()
        {
            string display = "";
            display += this.Name + ": " + this.Balance + "\n";
            foreach (Game game in this.Games)
            {
                display += "Purhased Games: " + game.Name + "\n";
            }
            return display;
        }
    }
}
