using System;

namespace SimpleFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            PizzaStore pizzaStore =
                new PizzaStore(new PizzaFactory());
            pizzaStore.OrderPizza("cheese");
        }
    }
}
