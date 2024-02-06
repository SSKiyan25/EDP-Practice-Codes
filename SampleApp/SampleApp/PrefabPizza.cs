using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class PrefabPizza : Pizza, PricedItem 
    {
        public PrefabPizza(string name, PizzaBase pizzaBase, double price, List<Topping> toppings) : base(name, pizzaBase)
        {
            this.Price = price;
            foreach (Topping topping in toppings)
                this.Toppings.Add(topping);
        }
        public double ComputePrice()
        {
            return this.Price;
        }

        public override string ToString()
        {
            return this.Name + " (" + this.Base + ") - " + this.Price + " dollars";
        }
    }
}
