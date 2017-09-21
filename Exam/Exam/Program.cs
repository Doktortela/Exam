using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Привет мир";
            char c = 'в';
            int i = s.WordCount(c);
            Console.WriteLine(i);
            Console.WriteLine(s.WordAdding());
            Console.ReadLine();
        }
    }

    public static class StringExtension
    {
        public static string WordAdding(this string str)
        {
            return str+" . PS: made by vova";
        }

        public static int WordCount(this string str, char c)
        {
            int counter = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == c)
                    counter++;
            }
            return counter;
        }
    }
}
