using System;

namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(10, 9));
            Console.WriteLine(Add(3.14m, 1.17m));
            Console.WriteLine(Add(13, 21, true));

        }
        public static int Add(int x, int y)
        {
            return x + y;
        }
        public static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }
        public static string Add(int x, int y, bool isTrue)
        {
            int sum = x + y;

            if (isTrue == true && sum == 1)
            {
                return $"{sum} dollar.";
            }
            else if (isTrue == true && sum != 1)
            {
                return $"{sum} dollars.";
            }
            else
            {
                return sum.ToString();
            }
        }
    }
}
