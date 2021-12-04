using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson6_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("введите предложение");

            string s = Console.ReadLine();

            string longword = string.Empty;

            string[] words = s.Split(' ');

            for (int i = 0; i < words.Length; i++)

                if (words[i].Length > longword.Length)

                    longword = words[i];

            Console.WriteLine(longword);

            Console.ReadKey();
        }
    }
}
