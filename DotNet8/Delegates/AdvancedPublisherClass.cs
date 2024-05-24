using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Delegates
{

    public class AdvancedPublisherClass
    {

        public static event EventHandler? SendNotify;


        public void SendNotifyToSubscribers(EventArgs e)
        {

            SendNotify?.Invoke(this, e);
        }

    }
}
