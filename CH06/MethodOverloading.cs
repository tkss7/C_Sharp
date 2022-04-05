//MethodOverloading.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06
{
    class Method_Overloading
    {
        static int Add(int x, int y)
        {
            return x + y;
        }

        static double Add(double x, double y)
        {
            return x + y;
        }

        static char Add(char x)
        {
            return (char)(x + 32);
        }

        static decimal Add(decimal x, decimal y)
        {
            return x + y;
        }


        static void Main(string[] args)
        {
            int ref1 = Add(10, 20);
            Console.WriteLine("ret : {0}", ref1);

            double ref2 = Add(1.1, 2.2);
            Console.WriteLine("ret2 : {0}", ref2);

            int ref3 = Add(100M, 200M);
            Console.WriteLine("ret3 : {0}", ref3);

            char ref4 = Add('a');         //하나 입력했으니 'a'와 공백을 더해서 반환하므로 'a' 출력
            Console.WriteLine("ret4 : {0}", ref4);
        }
    }
}