using System;

namespace AbstractFactory
{
    public class VeggiePizza : Pizza
    {
        PizzaIngredientFactory ingredientFactory;

        public VeggiePizza(PizzaIngredientFactory ingredientFactory) {
            this.ingredientFactory = ingredientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine($"Prepairing {Name}...");
            Dough = ingredientFactory.CreateDough();
            Sauce = ingredientFactory.CreateSauce();
            Cheese = ingredientFactory.CreateCheese();
            Clam = ingredientFactory.CreateClam();
        }
    }
}
