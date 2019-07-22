using System;
using System.Collections.Generic;

namespace FactoryMethod
{
    public abstract class Pizza
    {
        protected string Name { get; set; }
        protected string Dough { get; set; }
        protected string Sauce { get; set; }
        protected List<string> toppings = new List<string>();

        public void Prepare()
        {
            Console.WriteLine($"Preparing {Name}...");
            Console.WriteLine($"Tossing {Dough} dough...");
            Console.WriteLine($"Adding {Sauce} sauce...");
            Console.Write("Adding toppings of ");

            for (int i = 0; i < toppings.Count; i++)
            {
                if (i == toppings.Count - 1) {
                    Console.Write($"'{toppings[i]}'");
                }
                else {
                    Console.Write($"'{toppings[i]},'");
                }
            }

            Console.WriteLine();
        }

        public void Bake() {
            Console.WriteLine("Baking for 25 minutes at 350...");
        }

        public virtual void Cut() {
            Console.WriteLine("Cutting into diagonal slices...");
        }
        public void Box() {
            Console.WriteLine("Placing pizza in box...");
        }

        public string GetName() {
            return Name;
        }
    }
}
