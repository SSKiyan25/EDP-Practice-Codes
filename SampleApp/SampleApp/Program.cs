using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SampleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<PricedItem> items = new List<PricedItem>();
            items.Add(new PrefabPizza("Hawaiian", PizzaBase.Regular, 100.0, new List<Topping> { new Topping("Pineapple", 10), new Topping("Cheese",12), new Topping("Ham", 5)}));
            DIYPizza pizza = new DIYPizza("DIY1", PizzaBase.Thin);
            pizza.AddTopping(new Topping("Chili", 6));
            pizza.AddTopping(new Topping("Cheese", 12));
            pizza.AddTopping(new Topping("Ham", 5));
            items.Add(pizza);

            items.Add(new Beverage("Match", BeverageSize.Large, 120));

            double totalPrice = 0;
            foreach(PricedItem item in items)
            {
                totalPrice += item.ComputePrice();
                Console.WriteLine(item);
            }
            Console.WriteLine("Total cost: " + totalPrice);
            Console.ReadKey();
        }
    }
}
