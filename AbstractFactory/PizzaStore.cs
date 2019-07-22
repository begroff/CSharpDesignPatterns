using System;

namespace AbstractFactory
{
    public abstract class PizzaStore
    {
        public PizzaStore() {

        }

        public Pizza OrderPizza(string type) {
            Pizza pizza;

            pizza = CreatePizza(type);

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        public abstract Pizza CreatePizza(string type);
    }
}
