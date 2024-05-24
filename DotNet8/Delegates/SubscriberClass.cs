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
            PublisherClass.Notif += GetNotif; //add get notif to Notif event
        }


        public void GetNotif(string msg)
        {
            Console.WriteLine("called get Notif in subscriber class");
            Console.WriteLine(msg);
        }

    }
}
