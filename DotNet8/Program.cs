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

DelegateClass.RunStart t = () => Console.Write("test tun delegate from out side of this class");

SubscriberClass subscriber = new SubscriberClass();
