using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Delegates
{
    public class AdvancedSubscriberClass
    {
        public AdvancedSubscriberClass()
        {
            AdvancedPublisherClass.SendNotify += GetNotify;
        }



        public void GetNotify(object? sender, EventArgs e)
        {
            Console.WriteLine("get notify in subscriber class");
            Console.ReadLine();
        }
    }
}
