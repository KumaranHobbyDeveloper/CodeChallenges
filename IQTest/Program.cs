using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IQTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("2 4 7 8 10"));
            Console.WriteLine(Test("1 2 2"));
            Console.WriteLine(Test("2 4 7 8 10"));
            Console.WriteLine(Test("1 2 1 1"));
            Console.ReadLine();

        }

        public static int Test(string numbers)
        {
            if (string.IsNullOrWhiteSpace(numbers))
                return 0;
            int isNumber;
            if (numbers.Split(' ').Where(c => !int.TryParse(c,out isNumber)).Count() > 0)
                return 0;
            int index = 0;
            Dictionary<int,int> indexnumbers = numbers.Split(' ')
                                                .Select(number => new KeyValuePair<int, int>(++index, Convert.ToInt32(number)))
                                                .ToDictionary(x => x.Key, x => x.Value);

            var orderedGroups = numbers.Split(' ')
                              .Select(number => Convert.ToInt32(number))
                              .Select(i => new KeyValuePair<int, char>(i, i % 2 == 0 ? 'e' : 'o'))
                              .GroupBy(kvp => kvp.Value).OrderBy(grp => grp.Count());
            if (orderedGroups.Count() > 0)
                return indexnumbers.Where(kvp => kvp.Value == orderedGroups.First().First().Key).First().Key;
            else
                return 0;
        }
    }
}
