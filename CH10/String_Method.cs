//String_Method.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class String_Method
    {
        static void Main(string[] args)
        {
            string s1 = "Hello";
            Console.WriteLine(s1);
            s1 = "World";
            Console.WriteLine(s1);

            string s2 = "C is great !";
            string s3 = s2.Insert(1, "#"); // 1번쨰 열 자리에 # 추가
            Console.WriteLine(s3);

            int len = s3.Length;
            Console.WriteLine("문자열 길이 : {0}", len);

            string s4 = string.Copy(s1);
            Console.WriteLine(s4);

            string s5 = s4;
            Console.WriteLine(s4);
            Console.WriteLine(s5);
            s4 = "campus";
            Console.WriteLine(s4);
            Console.WriteLine(s5);

            string s6 = string.Concat("one", "two", "three");
            Console.WriteLine(s6);

            string s7 = string.Concat("multi", s4);
            Console.WriteLine(s7);

            string s8 = "Hello World";
            int n1 = s8.IndexOf("World"); //실패 : -1
            Console.WriteLine("s8.IndexOf(World) {0}", n1);

            string a1 = "Apple";
            string a2 = "apple";

            if (a1 == a2)
                Console.WriteLine("equal!");
            else
                Console.WriteLine("not equal!");

            if (a1.ToUpper().Equals(a2.ToUpper())) // 대문자로 만들고 비교
                Console.WriteLine("equal!");
            else
                Console.WriteLine("not equal!");

            int n2 = string.Compare(a1, a2, true); //두개의 문자열을 비교해서 같으면 0을 반환함, 같지않으면 0이 아님
            //int n2 = string.Compare(a1, a2, false); //두개의 문자열을 비교해서 같으면 0을 반환함, 같지않으면 0이 아님
            // true면 대소문자 구분 X, false면 대소문자 구분 O
            // 세번째 인자가 생략되면 false가 디폴트 값임
            Console.WriteLine("string.Compare(a1, a2, true) : {0}",n2);

            string a3 = s8.Substring(0, 5); // 0~ 5열만 추출
            Console.WriteLine(a3);

        }
    }
}
