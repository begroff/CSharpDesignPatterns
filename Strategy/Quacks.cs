using System;
using Strategy.Interfaces;

namespace Strategy
{
    public class Quacks : IQuackBehavior
    {
        public void Quack()
        {
            Console.WriteLine("Quack");
        }
    }
}