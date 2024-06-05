namespace DotNet8.Delegates
{
    public class PublisherClass
    {
        public static event NotifDelegate Notif;



        public static void NotifyHandler(string msg)
        {
            Console.WriteLine("called notify handler in publisher class");
            Notif.Invoke(msg);
            Console.WriteLine("after invoking");
        }

    }


    public class Test<T, T2> where T : class where T2 : class
    {
        public delegate T2 TestDelegate(T param);





        
        
    }

}
