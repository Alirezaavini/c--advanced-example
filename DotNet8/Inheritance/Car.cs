using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Inheritance
{
    public class Car
    {
        public int HP { get; set; }
        public string? Name { get; set; }

        public virtual void ShowDetails()
        {
            Console.WriteLine($"name: {Name} HP: {HP}");
        }
    }
}
