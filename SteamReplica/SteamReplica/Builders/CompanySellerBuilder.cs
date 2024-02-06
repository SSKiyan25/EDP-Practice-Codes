using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamReplica.Classes;

namespace SteamReplica.Builders
{
    public class CompanySellerBuilder
    {
        private CompanySeller companySeller;

        public CompanySellerBuilder()
        {
            this.companySeller = new CompanySeller();
        }   

        public CompanySellerBuilder Name(string name)
        {
            this.companySeller.Name = name;
            return this;
        }

        public CompanySellerBuilder Description(string description)
        {
            this.companySeller.Description = description;
            return this;
        }

        public CompanySellerBuilder Game(Game game)
        {
            this.companySeller.Games.Add(game);
            return this;
        }

        public CompanySeller Build()
        {
            return this.companySeller;
        }
    }
}
