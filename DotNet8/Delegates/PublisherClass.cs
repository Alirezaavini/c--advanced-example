using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Delegates
{
    public class PublisherClass
    {
        public static event NotifDelegate Notif;



        public static void NotifyHandler(string msg)
        {
            Console.WriteLine("called notify handler in publisher class");
            Notif.Invoke(msg);
            Console.WriteLine("after invoking");
        }

    }
}
