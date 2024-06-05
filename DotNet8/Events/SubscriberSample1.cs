using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Events
{
    public class SubscriberSample1
    {

        public SubscriberSample1()
        {
            PublisherClassSample.PublisherEvent += GetMessage;
        }




        public void GetMessage(object? source, string? msg)
        {
            Console.WriteLine("message in subscriber 1");
            Console.WriteLine(msg);
        }
    }
}
