using System;
using AdapterPattern;
namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new Adapter();

            target.Request();

            Console.WriteLine("\nUsing the adapter to call the specific request:");
            target = new Adapter2();
            target.Request();
        }
    }
}