using EmailSenderInterfaces;
using System;
using System.Collections.Generic;
using System.IO;
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
            try
            {
                InterfaceResolver ir = new InterfaceResolver("MyConfig2.txt");
                IEmailSender ES = ir.Instantiate<IEmailSender>();
                ES.SendEmail("ciao", "mattia");
                ES.SendEmail("hello", "john");
                Console.WriteLine("\n\n");
                IEmailSender ES2 = ir.Instantiate<IEmailSender>();
                ES2.SendEmail("ciao", "mattia");
                ES2.SendEmail("hello", "john");
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("pathname errato/i");
            }
        }
    }
}
