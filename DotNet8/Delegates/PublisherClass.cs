using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Delegates
{
    public delegate void Notify(string msg); //1 define delegate
    public class PublisherClass
    {
        public event Notify Notife;  //2 use delegate to define an event

        public void StartNotify()
        {
            NotifyHandler("msg from publisher");
        }

        public virtual void NotifyHandler(string msg)
        {
            Console.WriteLine("do in publisher first", msg);
            Notife?.Invoke(msg);
        }

    }
}
