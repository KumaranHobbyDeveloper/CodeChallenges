using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingDuplicates
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DuplicateCount("Indivisibility"));
            Console.ReadLine();
        }

        public static int DuplicateCount(string str)
        {
            if (string.IsNullOrEmpty(str))
                return 0;
            var grouped = str.ToLower().GroupBy(c => c);
            var actualCount = grouped
                                .Where(grp => grp.Count() > 1)
                                .Count();
            return actualCount;

        }
    }
}
