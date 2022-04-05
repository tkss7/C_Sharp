//Array_MenberMethod.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class Array_MenberMethod
    {
        static void Main(string[] args)
        {
            int[] data1 = { 10, 20 };
            int[] copy = data1; // 참조

            copy[0]++;
            copy[1]++;

            foreach (int n in data1)
                Console.Write("{0}, ", n);
            Console.WriteLine();

            int[] data2 = { 10, 10 };
            int[] copy2 = (int[])data2.Clone(); // 복제
            copy[0]++;
            copy[1]++;

            foreach (int n in data2)
                Console.Write("{0}, ", n);
            Console.WriteLine();

            int[] data3 = { 10, 10 };
            int[] copy3 = new int[5];
            //data3.CopyTo(copy3, 2); // 2열의 위치부터 (시작하여)복사받음 ex) 0, 0, 10, 10, 0
            data3.CopyTo(copy3, 0); // 배열의 내용을 복사받음 : 0열부터 (시작하여)복사받음 ex) 10, 10, 0, 0, 0

            foreach (int n in copy3)
                Console.Write("{0}, ", n);
            Console.WriteLine();




        }

    }
}
