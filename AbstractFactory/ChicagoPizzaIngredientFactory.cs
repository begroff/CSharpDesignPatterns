using System;

namespace AbstractFactory
{
    public class ChicagoPizzaIngredientFactory : PizzaIngredientFactory
    {
        public Dough CreateDough()
        {
            Console.WriteLine("Using Thick Crust Dough...");
            return new ThickCrustDough();
        }

        public Sauce CreateSauce()
        {
            Console.WriteLine("Using Plum Tomato Sauce...");
            return new PlumTomatoSauce();
        }

        public Cheese CreateCheese()
        {
            Console.WriteLine("Using Mozzarella Cheese...");
            return new MozzarellaCheese();
        }

        public Veggies[] CreateVeggies()
        {
            Console.WriteLine("Using Black Olives, Spinach & Eggplant...");
            Veggies[] veggies =  {
                new BlackOlives(),
                new Spinach(),
                new Eggplant()
            };

            return veggies;
        }

        public Pepperoni CreatePepperoni()
        {
            Console.WriteLine("Using Sliced Pepperoni...");
            return new SlicedPepperoni();
        }

        public Clams CreateClam()
        {
            Console.WriteLine("Using Frozen Clams...");
            return new FrozenClams();
        }
    }
}
