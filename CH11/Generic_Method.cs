//Generic_Method.cs 04/06
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH11
{


    class Generic_Method
    {
        public static void CopyArray<T>(T[] sour, T[] targ)
        {
            for (int i = 0; i < sour.Length; i++)
                targ[i] = sour[i];
        }

        static void Main(string[] args)
        {
            int[] source = { 1, 2, 3, 4, 5 };
            int[] target = new int[source.Length];

            CopyArray<int>(source, target);

            foreach (int item in target) //item에 target에 있는 내용을 하나하나 꺼내와라
                Console.Write("{0}, ", item);
            Console.WriteLine();

            string[] s2 = { "one", "two", "three", "four", "five", "six" };
            string[] t2 = new string[s2.Length];

            CopyArray<string>(s2, t2);
            foreach (string item in t2) //item에 target에 있는 내용을 하나하나 꺼내와라
                Console.Write("{0}, ", item);
            Console.WriteLine();



        }
    }
}
