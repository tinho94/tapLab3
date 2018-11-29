using EmailSenderInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailSenderImplementation2
{
    public class EmailSenderImplementation2 : IEmailSender
    {
        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("EmailSenderImplementation2   SendEmail");
            return false;
        }
    }
}
