using System;

namespace AbstractFactory
{
    public class NYPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough() {
            Console.WriteLine("Using Thin Crust Dough...");
            return new ThinCrustDough();
        }

        public Sauce CreateSauce() {
            Console.WriteLine("Using Marinara Sauce...");
            return new MarinaraSauce();
        }

        public Cheese CreateCheese() {
            Console.WriteLine("Using Reggiano Cheese...");
            return new ReggianoCheese();
        }

        public Veggies[] CreateVeggies() {
            Console.WriteLine("Using Garlic, Onion, Mushroom & Red Peppers...");
            Veggies[] veggies =  {
                new Garlic(),
                new Onion(),
                new Mushroom(),
                new RedPepper()
            };

            return veggies;
        }

        public Pepperoni CreatePepperoni() {
            Console.WriteLine("Using Sliced Pepperoni...");
            return new SlicedPepperoni();
        }

        public Clams CreateClam() {
            Console.WriteLine("Using Fresh Clams...");
            return new FreshClams();
        }
    }
}