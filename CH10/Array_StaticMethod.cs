//Array_StaticMethod.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class Array_StaticMethod
    {
        static void PrintArray(int[] arr)
        {
            Console.WriteLine();
            foreach (int n in arr)
                Console.Write("{0}, ",n);
            Console.WriteLine();
        }


        //Array 클래스가 제공해주는 메서드 : 정적메서드
        static void Main(string[] args)
        {
            int[] arr1 = { 20, 10, 50, 64, 90, 74, 4, 90, 4, 100 };

            PrintArray(arr1);

            Array.Clear(arr1, 0, arr1.Length); // 0번쨰 열부터 길이만큼 0으로 지운다.
            PrintArray(arr1);

            int[] arr2 = { 20, 10, 50, 64, 90, 74, 4, 90, 4, 100 };
            int[] arr3 = new int[arr2.Length];

            Array.Copy(arr2,arr3,arr2.Length); //arr2를 arr3에 길이만큼 복사해준다.
            PrintArray(arr3);

            Array.Clear(arr3, 0, arr3.Length);
            Array.Copy(arr2, 5, arr3, 5, 3); // arr2 의 5열부터 arr3의 5열에 3개만 복사한다.
            PrintArray(arr3);

            PrintArray(arr2);
            int N = Array.IndexOf(arr2, 90); //검색을 못하면 -1을 반환, 찾으면 인덱스를 반환
            Console.WriteLine("{0}, {1} ", N, arr2[N]);

            //int N = Array.IndexOf(arr3, 90); //검색을 못하면 -1을 반환, 찾으면 인덱스를 반환
            //Console.WriteLine("{0}, {1} ", N, arr2[N]);

            Array.Sort(arr2); //오름차순 정렬
            PrintArray(arr2);

            Array.Reverse(arr2); // 기본배열을 역순으로 바꿀 수 있다.
            PrintArray(arr2);


        }
    }
}
