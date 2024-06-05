using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Delegates
{
    public class SubscriberClass
    {

        //public SubscriberClass()
        //{
        //    PublisherClass.Notif += GetNotif; //add get notif to Notif event
        //}


        public void GetNotif(string msg)
        {
            Console.WriteLine("called get Notif in subscriber class");
            Console.WriteLine(msg);
        }

        public void Print()
        {
            foreach (var e in GetEnumerator())
            {
                Console.WriteLine(e.ToString());
            }
        }

        public IEnumerable<int> GetEnumerator()
        {
            int a = 0;
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("in get enumerator");
                yield return a;
                a += 2;
            }
        }

    }
}
