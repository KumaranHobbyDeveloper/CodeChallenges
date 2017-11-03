using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FindNextSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(FindNextSquare(121));
            Console.WriteLine(FindNextSquare(625));
            Console.WriteLine(FindNextSquare(114));
            Console.ReadLine();
        }

        public static long FindNextSquare(long num)
        {
            double sqrtValue = Math.Sqrt(num);
            if (sqrtValue == Math.Round(sqrtValue))
                return (long)((sqrtValue + 1) * (sqrtValue + 1));
            else
                return -1;

        }
    }

}
