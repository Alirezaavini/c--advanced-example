using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Delegates
{
    public class SubscriberClass
    {
        public SubscriberClass()
        {
            PublisherClass publisherClass = new PublisherClass();
            publisherClass.Notife += GetNotif;
            publisherClass.StartNotify();
        }


        public void GetNotif(string msg)
        {
            Console.WriteLine("doing from subscriber");
            Console.WriteLine(msg);
        }
    }
}
