using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Comparision
{
    public static class Comparision
    {

        public static void StringComparision()
        {

            var s1 = "a";
            var s2 = "A";

            var result = s1.Equals(s2, StringComparison.OrdinalIgnoreCase);
            var result2 = s1 == s2;

            Console.WriteLine(result);
            Console.WriteLine(result2);

        }

    }
}
