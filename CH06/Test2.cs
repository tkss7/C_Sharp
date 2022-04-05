//Test2.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06
{
    class Test2
    {
        static void swap(ref int a, ref int b)
        {
            int tmp;
            tmp = a;
            a = b;
            b = tmp;
        }
        static void Main(string[] args)
        {
            int n1 = 100, n2 = 200;

            Console.WriteLine("n1 : {0}, n2 : {1}", n1, n2);

            swap(ref n1, ref n2);

            Console.WriteLine("n1 : {0}, n2 : {1}", n1, n2);

        }
    }
}