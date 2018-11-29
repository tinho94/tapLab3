using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailSenderInterfaces;

namespace EmailSenderImplementation1
{
    public class EmailSenderImplementation1 : IEmailSender
    {
        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("EmailSenderImplementation1   SendEmail");
            return false;
        }
    }
}
