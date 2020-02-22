using System;

namespace Singleton
{
    /// <summary>
    /// https://csharpindepth.com/Articles/Singleton
    /// </summary>
    public sealed class Singleton
    {
        private static Singleton instance = new Singleton();
        //private static readonly object padlock = new object();

        // Explicit static constructor to tell C# compiler
        // not to mark type as beforefieldinit
        static Singleton()
        {
            Console.WriteLine("Static constructor called");
        }

        private Singleton()
        {
            Console.WriteLine("Private constructor called");
        }

        public static Singleton Instance
        {
            // Thread safety with lock on an object
            // get
            // {
            //     lock (padlock)
            //     {
            //         if (instance = null)
            //         {
            //             instance = new Singleton();
            //         }
            //     }

            //     return instance;
            // }

            get
            {
                return instance;
            }
        }

        public void Output()
        {
            Console.WriteLine("Hello Singleton!");
        }
    }
}
