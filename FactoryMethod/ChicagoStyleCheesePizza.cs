using System;

namespace FactoryMethod
{
    public class ChicagoStyleCheesePizza : Pizza
    {
        public ChicagoStyleCheesePizza() {
            Name = "Chicago Style Deep Dish Cheese Pizza";
            Dough = "Extra Thick Crust";
            Sauce = "Plum Tomato";

            toppings.Add("Shredded Mozzarella Cheese");
        }

        public override void Cut() {
            Console.WriteLine("Cutting the pizza into square slices...");
        }
    }
}
