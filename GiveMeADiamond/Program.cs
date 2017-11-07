using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GiveMeADiamond
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(print(3));
            Console.WriteLine(print(5));
            Console.WriteLine(print(4));
            Console.ReadLine();

        }

        public static string print(int n)
        {
            int whitespacecount;
            if ((n < 0) || (n % 2 == 0) || (n == 1)) return null;

            string AscendingLine = string.Empty;
            for (int iloop = 1; iloop <= n - 2; iloop += 2)
            {
                whitespacecount = (n - iloop) / 2;
                //AscendingLine += new string(' ', whitespacecount) + new string('*', iloop) + new string(' ', whitespacecount) + "\n";
                AscendingLine += new string(' ', whitespacecount) + new string('*', iloop) + "\n";
            }

            string CenterLine = new string('*', n) + "\n" ;

            string DescendingLine = string.Empty;
            for (int iloop = n - 2; iloop >= 1; iloop -= 2)
            {
                whitespacecount = (n - iloop) / 2;
                //DescendingLine += new string(' ', whitespacecount) + new string('*', iloop) + new string(' ', whitespacecount) + "\n";
                DescendingLine += new string(' ', whitespacecount) + new string('*', iloop) + "\n";
            }

            return AscendingLine + CenterLine + DescendingLine;
        }
    }
}
