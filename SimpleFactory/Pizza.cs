using System;

namespace SimpleFactory
{
    public class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing...");
        }

        public void Bake()
        {
            Console.WriteLine("Baking for 25 minutes at 350...");
        }

        public virtual void Cut()
        {
            Console.WriteLine("Cutting into diagonal slices...");
        }
        public void Box()
        {
            Console.WriteLine("Placing pizza in box...");
        }
    }
}
