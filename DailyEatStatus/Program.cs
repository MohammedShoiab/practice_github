using System;

namespace DailyEatStatus
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
<<<<<<< HEAD
            Console.WriteLine("Hello Mirha!");
            Console.WriteLine("Hello Mirha11!");
            Console.WriteLine("Hello Mirha12!");
<<<<<<< HEAD
            Console.WriteLine("Hello Mirha222!");
            Console.WriteLine("Hello Mirha223!");
=======
>>>>>>> parent of 31680c6 (chnage 2nd)
=======
>>>>>>> parent of 7cb3e55 (message)
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
