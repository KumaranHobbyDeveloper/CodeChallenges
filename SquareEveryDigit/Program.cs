using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareEveryDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SquareDigits(9119));
            Console.ReadLine();
        }

        public static int SquareDigits(int n)
        {
            if (n == 0)
                return 0;
           return int.Parse(string.Join("", n.ToString().Select(d => { return int.Parse(d.ToString()) * int.Parse(d.ToString()); })));
        }
    }
}
