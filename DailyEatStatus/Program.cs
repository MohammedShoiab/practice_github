using System;

namespace DailyEatStatus
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Hello Mirha!");
            Console.WriteLine("Hello Mirha11!");
            Console.WriteLine("Hello Mirha12!");
            DailyEat.foodfunc();
        }
    }
    public  class DailyEat
    {
        public static string food;
        public static DateTime time;

        public static void foodfunc()
        {
            food = "rice";
            Console.WriteLine("food is awsome {0}", food);
            Console.WriteLine("time is " + time.TimeOfDay);
        }
    }
}
