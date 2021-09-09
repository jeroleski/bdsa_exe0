using System;

namespace MyApp
{
    public class Program
    {
        public static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");

            var line = Console.ReadLine();
            int a;
            if (! int.TryParse(line, out a)) {
                Console.WriteLine("Bish, you must write number!");
                return;
            }

            int year = int.Parse(line);
            bool isLeapYear = IsLeapYear(year);

            if (isLeapYear) {
                Console.WriteLine("yay");
            } else {
                Console.WriteLine("nay");
            }
        }

        public static bool IsLeapYear(int year)
        {
            if (year % 100 == 0) {
                return year % 400 == 0;
            } else {
                return year % 4 == 0;
            }
        }
    }
}
