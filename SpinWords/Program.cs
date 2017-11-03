using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpinWords
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(SpinWords("Hey fellow warriors"));
            Console.WriteLine(SpinWords("This is a test"));
            Console.WriteLine(SpinWords("This is another test"));
            Console.ReadLine();
        }

        public static string SpinWords(string sentence)
        {
            if (!string.IsNullOrWhiteSpace(sentence))
            {
                string[] words = sentence.Split(' ');
                string[] spinnedWords = new string[words.Length];
                int iloop = 0;
                foreach (string word in words)
                {
                    spinnedWords[iloop] = word.Length >= 5 ? string.Join("", word.Reverse().Select(c => c.ToString())) : word;
                    iloop++;
                }

                return string.Join(" ", spinnedWords);
            }
            else return string.Empty;
        }
    }
}
