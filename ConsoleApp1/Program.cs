using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TinyDependencyInjectionContainer;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            InterfaceResolver ir=new InterfaceResolver("MyConfig2.txt");
        }
    }
}
