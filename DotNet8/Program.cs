using DotNet8.Inheritance;
using DotNet8.Samples;
using DotNet8.Virtual;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;


////TestParameter.Run();

Console.WriteLine("");




void MyFunction(int a)
{
    Console.WriteLine(a);
}


TestDelegate t = MyFunction;
t.Invoke(2);

public delegate void TestDelegate(int a);
