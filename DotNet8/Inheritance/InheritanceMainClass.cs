namespace DotNet8.Inheritance
{
    public class InheritanceMainClass : SuperMainClass
    {
        public InheritanceMainClass() : base(nameof(InheritanceMainClass))
        {

        }

        ~InheritanceMainClass()
        {
            Console.WriteLine("end of class");
            Console.ReadLine();
        }


        public void Run()
        {
            BMW bmw1 = new BMW();
            Car car = new Car();

            // bmw1 = car; compile time error

            car = bmw1;
        }


    }
}
