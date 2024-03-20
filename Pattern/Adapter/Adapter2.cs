using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    public class Adapter2 : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter2()
        {
            _adaptee = new Adaptee();
        }

        public void Request()
        {
            Console.WriteLine("Adapter2: Request called");
            _adaptee.SpecificRequest();
        }
    }
}
