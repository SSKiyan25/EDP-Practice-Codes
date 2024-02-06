using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    public class DIYPizza : Pizza, PricedItem
    {
        public DIYPizza(string name, PizzaBase pizzaBase) : base(name, pizzaBase)
        {
        }

        public void AddTopping(Topping topping)
        {
            if (this.Toppings.Contains(topping)) return;
            this.Toppings.Add(topping);
        }

        public void ClearToppings()
        {
            this.Price = 0;
            this.Toppings.Clear();
        }

        public double ComputePrice()
        {
            double price = 0;
            switch (this.Base)
            {
                case PizzaBase.Thin:
                    price = 50;
                    break;
                case PizzaBase.Thick:
                    price = 150;
                    break;
                case PizzaBase.Regular:
                    price = 80;
                    break;
            }
            foreach (Topping topping in this.Toppings)
                price += topping.Price;

            return price;
        }

        public override string ToString()
        {
            string disp = this.Name + " (" + this.Base + ") - " + this.ComputePrice() + " Dollars";
            foreach(Topping topping in this.Toppings)
                disp += "\t" + topping + "\n";
            return disp;
        }
    }
}
