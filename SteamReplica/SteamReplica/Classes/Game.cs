using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace SteamReplica.Classes
{
    public class Game
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public double Cost { get; set; }

        /// public CompanySeller? CompanySeller;

        public Game() 
        {
            this.Name = string.Empty;
            this.Description = string.Empty;
            this.Cost = 0;
            ///this.CompanySeller = null;
        }

        public override string ToString()
        {
            return this.Name + " -- " + this.Description + " == " + this.Cost;
        }
    }
}
