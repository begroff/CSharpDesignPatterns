using System;

namespace AbstractFactory
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            PizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();

            if (type.Equals("cheese")) {
                pizza = new CheesePizza(ingredientFactory);
                pizza.Name = "New York Style Cheese Pizza";
            }
            else if (type.Equals("veggie")) {
                pizza = new VeggiePizza(ingredientFactory);
                pizza.Name = "New York Style Veggie Pizza";
            }
            else if (type.Equals("clam")) {
                pizza = new ClamPizza(ingredientFactory);
                pizza.Name = "New York Style Clam Pizza";
            }
            else if (type.Equals("pepperoni")) {
                pizza = new PepperoniPizza(ingredientFactory);
                pizza.Name = "New York Style Pepperoni Pizza";
            }

            return pizza;
        }
    }
}
