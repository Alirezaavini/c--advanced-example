namespace DotNet8.Virtual
{
    public class Dog : Animal
    {

        public sealed override void PrintSound()
        {
            Console.WriteLine("hop hop");
        }
    }
}
