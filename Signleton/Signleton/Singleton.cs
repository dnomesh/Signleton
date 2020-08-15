using System;
using System.Collections.Generic;
using System.Text;

namespace Signleton
{
    public sealed class Singleton
    {
        private static readonly object obj = new object();
        private Singleton()
        {
            Console.WriteLine("Singleton 1");
        }

        private static readonly Lazy<Singleton> instance = new Lazy<Singleton>(()=> new Singleton());

        public static Singleton GetInstance
        {
            get
            {
                return instance.Value;
            }
        }

        public void PrintDetails(string message)
        {
            Console.WriteLine(message);
        }
    }
}
