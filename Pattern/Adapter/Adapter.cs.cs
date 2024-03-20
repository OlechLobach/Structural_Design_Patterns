using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter()
        {
            _adaptee = new Adaptee();
        }

        public void Request()
        {
            Console.WriteLine("Adapter: Request called");
            _adaptee.SpecificRequest();
        }
    }
}