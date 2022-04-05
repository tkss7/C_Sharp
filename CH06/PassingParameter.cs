//PassingParameter.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06
{


    class PassingParameter
    {
        static void PassByVal(int x, int y)
        {
            x++;
            y++;
        }

        static void PassByRef(ref int x, ref int y)
        {
            x++;
            y++;
        }

        static void PassByOut(out int x, out int y)
        {
            // 다중 return이 가능하다?
            //x++; //out 기존값을 사용할 수 없고 저장만 가능하다.
            // y++;
            x = 30;
            y = 40;
        }

        static void Main(string[] args)
        {
            int a1 = 10, b1 = 20;
            int a2 = 10, b2 = 20;
            int a3 = 10, b3 = 20;

            PassByVal(a1, b1);
            Console.WriteLine("a1: {0}, b1: {0}", a1, b1);

            PassByRef(ref a2, ref b2); // C++의 참조자 
            Console.WriteLine("a1: {0}, b1: {0}", a2, b2);

            PassByOut(out a3, out b3);
            Console.WriteLine("a1: {0}, b1: {0}", a3, b3);
        }
    }
}
