using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RemoveTheMnimum
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(string.Join(" ",RemoveSmallest(new List<int> { 1, 2, 3, 4, 5 }).Select(i =>i.ToString())));
            Console.WriteLine(string.Join(" ", RemoveSmallest(new List<int> { 5, 3, 2, 1, 4 }).Select(i => i.ToString())));
            Console.WriteLine(string.Join(" ", RemoveSmallest(new List<int> { 1, 2, 3, 1, 1 }).Select(i => i.ToString()))); 
            Console.ReadLine();
        }

        public static List<int> RemoveSmallest(List<int> numbers)
        {
            if (numbers == null)
                return null;
            if (numbers.Count == 0)
                return new List<int>();
            int numberToBeRemoved = numbers.OrderBy(number => number).ToList()[0];
            int iIndex = 0;
            while (true)
            {
                if (numberToBeRemoved == numbers[iIndex]) break;
                else iIndex++;
            }
            numbers.RemoveAt(iIndex);
            return numbers;
        }
    }


}
