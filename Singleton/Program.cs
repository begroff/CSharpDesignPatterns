using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            Singleton.Instance.Output();
            Singleton.Instance.Output();
        }
    }
}
