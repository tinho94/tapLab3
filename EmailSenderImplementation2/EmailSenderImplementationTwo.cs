using EmailSenderInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderImplementation2
{
    public class EmailSenderImplementationTwo : IEmailSender
    {
        private static int numberOfInstances = 0;
        private readonly int instanceNum;

        public EmailSenderImplementationTwo()
        {
            instanceNum = numberOfInstances++;
        }

        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("\nEmailSenderImplementation1 instanceNum={0}   SendEmail\nsent:{1}\nto:{2}", this.instanceNum, to, body);
            return false;
        }
    }
}
