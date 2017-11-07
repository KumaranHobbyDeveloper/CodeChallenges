using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReplaceWithAlphabetPosition
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine(AlphabetPosition("A"));
            //Console.WriteLine(AlphabetPosition("T"));
            Console.WriteLine(AlphabetPosition("The sunset sets at twelve o' clock."));
            Console.WriteLine(AlphabetPosition("The narwhal bacons at midnight."));
            Console.ReadLine();
        }

        public static string AlphabetPosition(string text)
        {
            return string.Join(" ", text.Replace(" ","")
                .Where(c => Char.IsLetter(c))
                .Select(c => ((int)Char.ToUpperInvariant(c) - 64).ToString()));
        }
    }
}
