namespace DotNet8.Samples
{
    internal class ClassSample
    {
        
        public ClassSample(string name)
        {
            Name = name;
            Console.WriteLine("constructor");
        }

        string name;
        public required string Name { get { return name; } set { name = value; } }

    }

}