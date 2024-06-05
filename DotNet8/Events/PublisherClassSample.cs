using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Events
{
    public class PublisherClassSample
    {
        public static event EventHandler<string>? PublisherEvent;

        public void Fire()
        {
            PublisherEvent?.Invoke(this, "message from publisher");
        }

    }
}
