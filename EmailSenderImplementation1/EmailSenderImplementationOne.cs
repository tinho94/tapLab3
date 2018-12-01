using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EmailSenderInterfaces;

namespace EmailSenderImplementation1
{
    public class EmailSenderImplementationOne : IEmailSender
    {
        private static int numberOfInstances = 0;
        private int instanceNum;

        public EmailSenderImplementationOne()
        {
            instanceNum=numberOfInstances++;
        }

        public bool SendEmail(string to, string body)
        {
            Console.WriteLine("EmailSenderImplementation1 instanceNum={0}   SendEmail\nsent:{1}\nto:{2}",this.instanceNum,to,body);
            return false;
        }
    }
}
