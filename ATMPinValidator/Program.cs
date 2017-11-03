using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ATMPinValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("1 : " + ValidatePin("1"));
            Console.WriteLine("12 : " + ValidatePin("12"));
            Console.WriteLine("123 : " + ValidatePin("123"));
            Console.WriteLine("1234 : " + ValidatePin("1234"));
            Console.WriteLine("12345 : " + ValidatePin("12345"));
            Console.WriteLine("1234567 : " + ValidatePin("1234567"));
            Console.WriteLine("-12345 : " + ValidatePin("-12345"));
            Console.WriteLine("1.2345 : " + ValidatePin("1.2345"));
            Console.WriteLine("00000000 : " + ValidatePin("00000000"));
            Console.ReadLine();
        }

        public static bool ValidatePin(string pin)
        {
            UInt32 iloop;
            bool result = false;
            if (pin.Length == 4 || pin.Length == 6)
                result = UInt32.TryParse(pin,out iloop);
            return result; 
        }
    }

}
