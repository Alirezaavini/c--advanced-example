using DotNet8;
using DotNet8.Delegates;
using DotNet8.Events;
using DotNet8.Inheritance;
using DotNet8.Samples;
using DotNet8.Virtual;
using System.Data.SqlTypes;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

var title = "This is my title";


SubscriberSample1 sample1 = new SubscriberSample1();
PublisherClassSample pub = new PublisherClassSample();

pub.Fire();

var username = Environment.UserName;
Console.WriteLine(username);