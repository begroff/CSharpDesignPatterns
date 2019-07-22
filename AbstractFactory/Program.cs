using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore nyPizzaStore =
                new NYPizzaStore();

            PizzaStore chicagoPizzaStore = new ChicagoPizzaStore();

            Pizza pizza = nyPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Ethan ordered a {pizza.GetName()}");

            Console.WriteLine();

            pizza = chicagoPizzaStore.OrderPizza("cheese");
            Console.WriteLine($"Nate ordered a {pizza.GetName()}");
        }
    }
}
