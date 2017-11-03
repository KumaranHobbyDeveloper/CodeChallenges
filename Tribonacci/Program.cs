using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tribonacci
{
    class Program
    {
        static void Main(string[] args)
        {
           Console.Write(String.Join(",", Tribonacci(new double[] { 1, 1, 1 }, 10)
                                .Select<double,string>(
                                                        d => d.ToString()
                                                        )));
            Console.ReadLine();
        }

        public static double[] Tribonacci(double[] signature, int n)
        {
            double[] tribonacci = new double[n];
            if (n == 0)
                return new double[] { 0 };
            if (signature.Length == 0)
                return new double[] { 0 };
            if (signature.Length != 3)
                throw new Exception("Incorrect Signature, cannot process the formula");

            for (int iloop = 0; iloop < n; iloop++)
            {
                if (iloop < 3)
                {
                    tribonacci[iloop] = signature[iloop];
                }
                else
                {
                    tribonacci[iloop] = tribonacci[iloop - 1] + tribonacci[iloop - 2] + tribonacci[iloop - 3];
                }
            }
            return tribonacci;
        }
    }
}
