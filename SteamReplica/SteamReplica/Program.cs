using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamReplica.Classes;
using SteamReplica.Builders;

namespace SteamReplica
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Steam home = new Steam();
            List<CompanySeller> companies = new List<CompanySeller>();
            CompanySellerBuilder companybuilder = new CompanySellerBuilder();
            GameBuilder gamebuilder = new GameBuilder();

            List<Game> games = new List<Game>();

            games.Add(gamebuilder.Name("Genshin Impact").Description("Open World RPG").Cost(499.99).Build());
            gamebuilder = new GameBuilder();
            games.Add(gamebuilder.Name("Growtopia").Description("2D Creative").Cost(0).Build());
            gamebuilder = new GameBuilder();
            games.Add(gamebuilder.Name("SpiderMan").Description("Marvel").Cost(2000).Build());
            gamebuilder = new GameBuilder();
            games.Add(gamebuilder.Name("Honkai Impact: Star Rail").Description("RPG Turn Based").Cost(500).Build());

            companies.Add(companybuilder.Name("HoyoVerse").Game(games[0]).Build());
            companybuilder = new CompanySellerBuilder();
            companies.Add(companybuilder.Name("Ubisoft").Game(games[1]).Build());
            companies[0].addGame(games[3]);
            home.addCompany(companies[0]);
            home.addCompany(companies[1]);

            ////companies.ForEach(company => Console.WriteLine(company));
            Console.WriteLine("Steam Featured Games");
            Console.WriteLine(home);
            Console.WriteLine("\n");
            List<Customer> customers = new List<Customer>();
            CustomerBuilder customerbuilder = new CustomerBuilder();

            customers.Add(customerbuilder.Name("Kiyan").Balance(5000).PaymentMethod(PaymentMethod.Paypal).Build());
            customerbuilder = new CustomerBuilder();
            customers.Add(customerbuilder.Name("NavsGaming").Balance(0).PaymentMethod(PaymentMethod.CashOnDelivery).Build());

            customers.ForEach(customers => Console.WriteLine(customers));
            string disp = "He is Too Poor";
            Console.WriteLine(customers[0].Name + " Would Want To Buy " + games[0].Name);
            if (home.purchaseGame(customers[0], games[0]))
            {
                Console.WriteLine("Successfully Bought");
                Console.WriteLine(customers[0]);
            }
            else
                Console.WriteLine(disp);

            if (home.purchaseGame(customers[0], games[3]))
            {
                Console.WriteLine("Successfully Bought");
                Console.WriteLine(customers[0]);
            }
            else
                Console.WriteLine(disp);

            Console.WriteLine(customers[1].Name + " Would Want To Buy " + games[0].Name);
            if (home.purchaseGame(customers[1], games[0]))
            {
                Console.WriteLine("Successfully Bought");
                Console.WriteLine(customers[1]);
            }
            else
                Console.WriteLine(disp);
        }
    }
}