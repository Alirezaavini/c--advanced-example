using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DotNet8.Virtual
{
    public static class MainClassOfVirtualSample
    {

        public static void Run()
        {
            Animal animal = new Animal();
            Dog dog = new Dog();

            animal.PrintSound();
            dog.PrintSound();


            Console.ReadLine();


        }

    }
}
