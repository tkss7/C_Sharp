//MethodParameter.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06
{
    class MethodParameter
    {
        static void Method1()
        {
            int count = 100;
            Console.WriteLine("Method1() : {0}", count);
        }
        static int Method2(int x, char y)
        {
            Console.WriteLine("Method2() : {0}, {1}", x, y);
            return x + (int)y;
        }

        static void Main(string[] args)
        {
            Method1();

            int ret = Method2(100, 'A');
            Console.WriteLine("ret : {0} ", ret);


        }
    }
}
