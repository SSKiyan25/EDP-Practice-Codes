using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteamReplica.Classes
{
    public class Steam
    {
        public List<CompanySeller> Companies;
        public List<Customer> Customers;

        public Steam()
        {
            this.Companies = new List<CompanySeller>();
            this.Customers = new List<Customer>();
        }

        public void addCompany(CompanySeller companySeller)
        {
            this.Companies.Add(companySeller);
        }

        public void addCustomer(Customer customer)
        {
            this.Customers.Add(customer);
        }
        public bool purchaseGame(Customer customer, Game game)
        {
            bool canPurchase = false;
            if (customer.Balance >= game.Cost)
            {
                customer.Balance -= game.Cost;
                customer.Games.Add(game);
                canPurchase = true;
            }
            return canPurchase;
        }

        public override string ToString()
        {
            string display = "\nCompanies: \n";
            foreach (CompanySeller s in Companies)
            { 
                display += s.ToString() + "\n"; 
            }
            return display;
        }
    }
}
