//MemoryAllocation.cs 04/01
using System;

namespace CH06
{
    class Memory_Allocation
    {
        static int salary = 350;

        static void funcA()
        {
            int age = 30;
            Console.WriteLine("Main() salary : {0}, age : {1}", salary, age);
            salary += 10;
        }
        static void Main(string[] args)
        {
            int age = 26;
            Console.WriteLine("Main() salary : {0}, age : {1}", salary, age);

            funcA();

            Console.WriteLine("Main() salary : {0}, age : {1}", salary, age);

            char[] str = new char[5] { 'A', 'B', 'C', 'D', 'E' };    //C#에서는 배열길이만큼 딱맞게 값을 초기화 시켜야함
            //str[0] = 'a';
            //str[1] = 'n';
            //str[2] = 'c';
            Console.WriteLine(str);
            Console.WriteLine(str[0]);


            string str2 = "kingdom";
            Console.WriteLine(str2);
            Console.WriteLine(str2[0]);

            //str2[0] = 's';    //상수라 수정 불가
            str2 = "ssibal";    //얜 가능, C#에서는 얘만 씀
            Console.WriteLine(str2);
            Console.WriteLine(str2[0]);
            Console.WriteLine(str.GetHashCode());
        }
    }
}