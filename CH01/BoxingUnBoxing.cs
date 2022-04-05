//BoxingUnBoxing.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH01
{
    class BoxingUnBoxing
    {
        public static void Main()
        {
            int a = 123;
            object b = (object)a; //Boxing heap의 정보를 참조하는 것
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.WriteLine("b.GetHashCode() : {0}", b.GetHashCode()); // b 가 저장하고 있는 주소


            object c = (int)b; //UnBoxing : heap의 정보를 stack에 반환하는것
            Console.WriteLine(b);
            Console.WriteLine(c);
        }
    }
}
