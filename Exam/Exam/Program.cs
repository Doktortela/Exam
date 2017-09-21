using Exam;
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



            List<int> someNewList = new List<int>();
            someNewList.Add(1);
            someNewList.Add(2);
            someNewList.Add(3);

            bool max = someNewList[2].GetMaxValue();
            Console.WriteLine("Максимальное значение = {0}", max);


            int q = 24;
            int w = 89;
            int e = q.Value(w);
            Console.WriteLine(e);


        }
    }

    public static class StringExtension
    {
        public static string WordAdding(this string str)
        {
            return str + " . PS: made by vova";
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

    public static class IntExtension
    {
        static public bool GetMaxValue(this int list)
        {
            
            return list % 11 == 0;
        }
         
        static public int Value(this int q, int w)
        {
            return q * w;
        }
    }
}
