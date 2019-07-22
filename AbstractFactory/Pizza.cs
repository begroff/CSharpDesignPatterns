using System;
using System.Collections.Generic;

namespace AbstractFactory
{
    public abstract class Pizza
    {
        public string Name { get; set; }
        protected Dough Dough { get; set; }
        protected Sauce Sauce { get; set; }
        protected Veggies[] Veggies {get; set; }
        protected Cheese Cheese {get; set; }
        protected Pepperoni Pepperoni {get; set; }
        protected Clams Clam {get; set; }

        public abstract void Prepare();

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

        public override string ToString() {
            return "";
        }
    }
}
