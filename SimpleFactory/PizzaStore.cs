using System;

namespace SimpleFactory
{
    public class PizzaStore
    {
        private PizzaFactory factory;

        public PizzaStore(PizzaFactory factory) {
            this.factory = factory;
        }

        public Pizza OrderPizza(string type) {
            Pizza pizza = null;

            pizza = factory.CreatePizza("cheese");

            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }
    }
}