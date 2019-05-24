using System;

namespace Strategy
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            // Inherits from Duck
            quackBehavior = new Quacks();
            flyBehavior = new FlyWithWings();
        }

        override public void Display()
        {
            Console.WriteLine("I'm a real mallard duck");
        }
    }
}