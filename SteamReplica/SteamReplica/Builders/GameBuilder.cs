using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamReplica.Classes;

namespace SteamReplica.Builders
{
    public class GameBuilder
    {
        private Game game;

        public GameBuilder()
        {
            this.game = new Game();
        }

        public GameBuilder Name(string name)
        {
            this.game.Name = name;
            return this;
        }

        public GameBuilder Description(string description)
        {
            this.game.Description = description;
            return this;
        }

        public GameBuilder Cost(double cost)
        {
            this.game.Cost = cost;
            return this;
        }

        /*public GameBuilder Company(CompanySeller company)
        {
            this.game.CompanySeller = company;
            return this;
        }*/

        public Game Build()
        {
            return this.game;
        }
    }
}
