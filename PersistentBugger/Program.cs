using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersistentBugger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Persistence(39));
            Console.WriteLine(Persistence(4));
            Console.WriteLine(Persistence(25));
            Console.WriteLine(Persistence(999));
            Console.ReadLine();
        }

        public static int Persistence(long n)
        {
            int iloopCount = 0;
            while (n >= 10)
            {
                long result = 1;
                List<long> numArray = new List<long>();
                while (true )
                    if (n / 10 > 0)
                    {
                        numArray.Add(n % 10);
                        n = n / 10;
                    }
                    else
                    {
                        numArray.Add(n);
                        break;
                    }
                foreach (long reminder in numArray)
                    result = result * reminder;
                n = result;
                if (numArray.Count > 1)
                    iloopCount++;
                else
                    break;
            }
            return iloopCount;
        }
    }
}
