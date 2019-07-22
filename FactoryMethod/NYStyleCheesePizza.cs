using System;

namespace FactoryMethod
{
    public class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza() {
            Name = "NY Style Sauce and Cheese Pizza";
            Dough = "Thin Crust";
            Sauce = "Marinara";

            toppings.Add("Grated Reggiano Cheese");
        }
    }
}
