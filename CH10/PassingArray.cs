//PassingArray.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class PassingArray
    {
        static void passArray1(int [] _arr1)
        {
            _arr1[0]++;
        }

        static void passArray2(int[,] _arr2)
        {
            _arr2[0,0]++;
            _arr2[1,0]++;
        }

        static void Main(string[] args)
        {
            int[] arr1 = { 10, 20 };
            int[,] arr2 = { { 1, 2, 3 }, { 4, 5, 6 } };

            passArray1(arr1);

            foreach (int n in arr1) //컬렉션을 순회하는 반복문
                //n은 읽기 전역변수라서 값을 수정할 수 없다.
                Console.WriteLine("{0}, ",n);
            Console.WriteLine();

            passArray2(arr2);

            foreach (int n in arr2) //컬렉션을 순회하는 반복문
                Console.WriteLine("{0}, ", n);
            Console.WriteLine();

        }
    }
}
