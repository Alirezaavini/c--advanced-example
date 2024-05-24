using DotNet8.Delegates;
using DotNet8.Inheritance;
using DotNet8.Samples;
using DotNet8.Virtual;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

var title = "This is my title";


//GenericDelegate<string> method = ConvertToUpper;
//method += ConvertToLower; //multi cast delegates
//method(title);

//Func<string , string> methods = ConvertToLower;

//TestMethodWithGettingDelegate(s => s = "asdfsadfasf");


//DelegateClass.RunStart t = (string t) => Console.Write("t {0}", t);

//SubscriberClass subscriber = new SubscriberClass();
//SbcriberClass2 subscriber2 = new SbcriberClass2();
AdvancedSubscriberClass subscriber2 = new AdvancedSubscriberClass();

AdvancedPublisherClass advancedPublisherClass = new AdvancedPublisherClass();
advancedPublisherClass.SendNotifyToSubscribers(EventArgs.Empty);
