using System;

namespace FactoryMethod
{
    public class NYPizzaStore : PizzaStore
    {
        public override Pizza CreatePizza(string type)
        {
            if (type.Equals("cheese")) {
                return new NYStyleCheesePizza();
            }
            else if (type.Equals("veggie")) {
                //return new NYStyleVeggiePizza();
            }
            else if (type.Equals("clam")) {
                //return new NYStyleClamPizza();
            }
            else if (type.Equals("pepperoni")) {
                //return new NYStylePepperoniPizza();
            }

            return null;
        }
    }
}
