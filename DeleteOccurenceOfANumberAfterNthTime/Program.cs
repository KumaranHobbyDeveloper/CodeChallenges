using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DeleteOccurenceOfANumberAfterNthTime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(",",DeleteNth(new int[] { 20, 37, 20, 21 }, 1).Select(i => i.ToString())));
            Console.WriteLine(string.Join(",", DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3).Select(i => i.ToString())));
            Console.ReadLine();
        }

        public static int[] DeleteNth(int[] arr, int x)
        {
            Dictionary<int, int> grpdNumbersbyCountGreaterThanI = arr.GroupBy(i => i)
                                                                  .Where(grp => grp.Count() > x)
                                                                  .Select(grp => new KeyValuePair<int, int>(grp.Key, 0))
                                                                  .ToDictionary(grp => grp.Key, grp => grp.Value);
            return arr.Where(i =>
            {
                if (!grpdNumbersbyCountGreaterThanI.Keys.Contains(i))
                { return true; }
                else if (grpdNumbersbyCountGreaterThanI.Keys.Contains(i) && grpdNumbersbyCountGreaterThanI[i] < x)
                { ++grpdNumbersbyCountGreaterThanI[i]; return true; }
                else
                { return false; }
            }).ToArray();
        }
    }
}
