using System;
using Strategy.Interfaces;

namespace Strategy
{
    public class FlyNoWay : IFlyBehavior
    {
        public void Fly()
        {
            Console.WriteLine("I can't fly");
        }
    }

}