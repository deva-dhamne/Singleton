namespace Singleton
{
    public class Program
    {
        public static void Main()
        {
            var logger1 = Logger.GetInstance();
            var logger2 = Logger.GetInstance();

            logger1.Log("First message");  
            logger2.Log("Second message"); 

            Console.WriteLine(ReferenceEquals(logger1, logger2)); 
        }
    }
}
