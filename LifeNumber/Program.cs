using System;

namespace LifeNumber
{
    class Program
    {

        static int lifeNumber(int n)
        {
            int number = 0;

            while (n > 0 || number > 9)
            {
                if (n == 0)
                {
                    n = number;
                    number = 0;

                }
                number += n % 10;
                n /= 10;

            }
            return number;
        }
        static void Main(string[] args)
        {
            int t = 13021999;
            Console.WriteLine(lifeNumber(t));
        }
    }
}
