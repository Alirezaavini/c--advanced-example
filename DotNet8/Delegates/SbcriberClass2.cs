using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Delegates
{
    public class SbcriberClass2
    {
        public SbcriberClass2()
        {
            PublisherClass.Notif += GetNotif; // add get notif to event
        }


        public void GetNotif(string msg)
        {
            Console.WriteLine("msg from subscriber 2 => " + msg);
        }
    }
}
