//SimPleType2.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01
{
    class SimPleType2
    {
        public static void Main()
        {
            int x1 = 100;
            Console.WriteLine(x1);

            uint x2 = (uint)x1; // 명시적 형변환
            Console.WriteLine(x2);

            x1 = -100;
            x2 = (uint)x1;
            Console.WriteLine(x1);
            Console.WriteLine(x2);

            int num = 500; //변수선언 후 사용하지 않으면 언더라인 나옴
            float fnum = 1.5F;

            string s1 = num.ToString(); // 값을 문자열로 변환
            string s2 = fnum.ToString();
            string s3 = 100.ToString();
            string s4 = 3.14.ToString();

            Console.WriteLine(s1);
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine(s4);

            Console.WriteLine("{0}, {1} ", num.GetType(), s1.GetType());

            int n1 = Int32.Parse(s1); //CTS형식 문법
            int n2 = int.Parse("200"); // 문자열을 값으로 변환 // C # 형식 문법
            double f1 = Double.Parse("1.9");
            bool b1 = Boolean.Parse("true");

            Console.WriteLine(n1);
            Console.WriteLine(n2);
            Console.WriteLine(f1);
            Console.WriteLine(b1);
            Console.WriteLine();

            Console.WriteLine("{0}, {1} ", n1.GetType(), b1.GetType());

        }
    }
}
