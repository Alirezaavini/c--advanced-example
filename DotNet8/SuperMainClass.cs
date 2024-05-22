namespace DotNet8
{
    public class SuperMainClass
    {
        public SuperMainClass(string subClassName)
        {
            Console.WriteLine($"class started to run. class name: {subClassName}");
        }

        ~SuperMainClass()
        {
            Console.WriteLine("finalizers");
        }
    }
}
