using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SteamReplica.Classes;

namespace SteamReplica.Builders
{
    public class CustomerBuilder
    {
        private Customer customer;

        public CustomerBuilder()
        {
            this.customer = new Customer();
        }

        public CustomerBuilder Name(string name)
        {
            this.customer.Name = name;
            return this;
        }

        public CustomerBuilder PaymentMethod(PaymentMethod paymentMethod)
        {
            this.customer.PaymentMethod = paymentMethod;
            return this;
        }
        public CustomerBuilder Balance(double balance)
        {
            if (balance >= 0)
                this.customer.Balance = balance;
            else
                throw new Exception("Invalid Inputted Balance");
            return this;
        }
        public CustomerBuilder Game(Game game)
        {
            this.customer.Games.Add(game);
            return this;
        }

        public Customer Build()
        {
            return this.customer;
        }
        
    }
}
