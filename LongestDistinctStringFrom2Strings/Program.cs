using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestDistinctStringFrom2Strings
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Longest("xyaabbbccccdefww", "xxxxyyyyabklmopq"));
            Console.ReadLine();
        }

        public static string Longest(string s1, string s2)
        {
            SortedSet<char> distinctChar = new SortedSet<char>();
            s1.All(c => { if (Char.IsLetter(c) && !distinctChar.Contains(c)) { distinctChar.Add(c); } return true; });
            s2.All(c => { if (Char.IsLetter(c) && !distinctChar.Contains(c)) { distinctChar.Add(c); } return true; });
            return string.Join("", distinctChar.ToArray());
        }
    }
}
