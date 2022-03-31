//NULLable.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
// C#에서는 null임 NULL은 C,C++
namespace CH01
{
    class NULLable
    {
        public static void Main()
        {
//nullable 변수
            //nullable 변수(int? ) : null을 저장할 수 있는 변수
            int? a=null;
            int b = 0;

            Console.WriteLine(a.HasValue); //값을 가지고 있으면 참
            Console.WriteLine(a !=null); // False 
            Console.WriteLine(a); //아무것도 안찍힘
            Console.WriteLine(b); // 0

            a = 100;
            Console.WriteLine(a.HasValue);
            Console.WriteLine(a !=null);
            Console.WriteLine(a);
            Console.WriteLine();

//var type 변수
            int num = 100;
            Console.WriteLine("{0}, {1}", num, num.GetType());

            //var type 변수는 값이 저장될 때 자료형이 결정된다. == auto ??
            var intTmp = 200;
            Console.WriteLine("{0}, {1}", intTmp, intTmp.GetType());

            //var a = 300; // 반드시 초기화를 시켜줘야 함 , 한번 준 타입은 바꾸짐 못함
       
            var Tmp2 = 3.4;
            Console.WriteLine("{0}, {1}", Tmp2, Tmp2.GetType());

            var Tmp3 = "campus";
            Console.WriteLine("{0}, {1}", Tmp3, Tmp3.GetType());

            var Tmp4 = new int[] { 10, 20, 30, 40 };
            Console.WriteLine(" {0}", Tmp4.GetType());

        }
    }
}
