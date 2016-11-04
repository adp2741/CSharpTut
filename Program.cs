using System;

namespace ConsoleApplication
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Hello how many hours of sleep did you get?");
            int hours = int.Parse(Console.ReadLine());

            if (hours >= 8)
            {
                Console.WriteLine("You got a lot of sleep.");
            }
            else
            {
                Console.WriteLine("{0} is not enough.", hours);
            }
        }
    }
}
