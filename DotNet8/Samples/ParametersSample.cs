namespace DotNet8.Samples
{
    public static class ParametersSample
    {

        public static void TestPerson(Person person)
        {
            person.FirstName = "Test"; //             
        }


        public static void ConvertIntToZeroByRef(ref int t)
        {
            t = 0;
        }

        public static void ConvertStringToZeroByRef(out string? t, out string t2)
        {
            t = "";
            t2 = ""; // you have to initialize all out parameter iside the method` 
        }

        public static void ConvertStringToZeroByIn(in string t) //t is readonly here
        {

        }
    }

    public static class TestParameter
    {
        public static void Run()
        {

            var alireza = new Person
            {
                FirstName = "alireza",
            };
            Console.WriteLine(alireza.FirstName);

            ParametersSample.TestPerson(alireza);

            Console.WriteLine(alireza.FirstName);


            #region ref
            int a = 1; // it's neseccery to initialize a


            ParametersSample.ConvertIntToZeroByRef(ref a);

            #endregion



            string t;

            ParametersSample.ConvertStringToZeroByRef(out string t2, out t);

            Console.ReadLine();
        }
    }
}
