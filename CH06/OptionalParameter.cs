//OptionalParameter.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06
{
    class OptionalParameter
    {
        static void PrintProfile(string name, string phone="", int salary=0) // 선택적 매개변수 ( 디폴트 인자)
        {
            Console.WriteLine("name : {0}, phone : {1}, salary : {2}", name, phone, salary);
        }

        static void Main(string[] args)
        {
            PrintProfile("홍길동");
            PrintProfile("홍길동","010-001-1234");
            PrintProfile("홍길동","010-001-1234",3400000);

            PrintProfile(salary: 3700000, phone: "010-001-1234", name: "이몽룡");
            //명명된 인자전달

        }

    }
}
