using System;

namespace Strategy
{
    public class ModelDuck : Duck
    {
        public ModelDuck()
        {
            flyBehavior = new FlyNoWay();
            quackBehavior = new Quacks();
        }

        override public void Display()
        {
            Console.WriteLine("I'm a model duck");
        }
    }
}