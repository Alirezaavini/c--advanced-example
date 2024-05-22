namespace DotNet8.Virtual
{
    public class Animal
    {
        public Animal()
        {

        }
        public Animal(string name)
        {
            this.Name = name;
        }

        public string? Name { get; set; }

        public virtual void PrintSound()
        {
            Console.WriteLine("none");
        }



    }
}
