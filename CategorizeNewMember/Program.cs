using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CategorizeNewMember
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write(string.Join(",",OpenOrSenior(new[] { new[] { 45, 12 }, new[] { 55, 21 }, new[] { 19, 2 }, new[] { 104, 20 } })));
            Console.ReadLine();
        }

        public static IEnumerable<string> OpenOrSenior(int[][] data)
        {
            string[] result = new string[data.Length];
            int iresult = 0;
            foreach (object applicant in data)
            {
                result[iresult] = (((int[])applicant)[0] >= 55 && ((int[])applicant)[1] > 7) ?  "Senior" : "Open";
                iresult++;
            }
            return result;
        }
    }
}
