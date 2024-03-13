using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolyDemo
{
    internal class NewKeyWord:BaseClass
    {
        public new void baseMethod() {
            Console.WriteLine("New keyword base class method");
        }
    }
}
