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
        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("EmailSenderImplementation2   SendEmail\nsent:{0}\nto:{1}", to, body);
            return false;
        }
    }
}
