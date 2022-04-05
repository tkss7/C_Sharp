//Array_Intro.cs 04/04
using System;
namespace CH10
{
    class C_sharp_Array
    {
        static void Main(string[] args)
        {
            Console.WriteLine("배열");
            int[] x = new int[5];       //선언과 동시에 힙에 20바이트 할당

            int[] y;                //배열변수 선언
            y = new int[5];            //메모리 할당하여 y가 주소 참조

            x[0] = 10;
            x[1] = 20;
            x[2] = 30;

            for (int i = 0; i < x.Length; i++)
                Console.Write("{0}, ", x[i]);
            Console.WriteLine();

            int[] z;
            z = x;     //z는 참조변수(ref)로 x의 시작주소를 가리킴

            for (int i = 0; i < x.Length; i++)
                Console.Write("{0}, ", z[i]);
            Console.WriteLine();

            z[0] = 100;
            z[1] = 200;

            for (int i = 0; i < x.Length; i++)
                Console.Write("{0}, ", x[i]);
            Console.WriteLine();

            int n = 5;
            int[] a2 = new int[n];    //런타임 수행

            //int[5] a1;       //문법 오류! 무조건 'int a1 = new int[5]' 형식으로 선언해야함
            //int a1[5];        //문법 오류! 무조건 'int a1 = new int[5]' 형식으로 선언해야함
            //int[] a1 = new int[-5]; //문법 오류! 음수는 올 수 없음
            //int[] a1 = new int[]; //문법 오류! 할당할 길이를 꼭 넣어줘야함


        }
    }
}