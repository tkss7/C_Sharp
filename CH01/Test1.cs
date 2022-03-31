//Test1.cs
using System;

/*
    키보드로 부터 성명, 출생년도, 월급을 입력받아 다음과 같이 출력하시오.

    성명 ? 홍길동
    출생년도 ? 1972
    월급 ? 35000000

    당신의 이름은 홍길동입니다.
    당신의 나이는 : 50세 입니다.
    당신의 연봉은 : \42,000,000 입니다.

 */

namespace CH01
{
    class Test1
    {
        public static void Main()
        {
            string name;
            string year_t;
            
            int year;
            
            Console.Write("성명 ? ");
            name=Console.ReadLine();
            

            Console.Write("출생년도 ? "); //1981
            year_t=Console.ReadLine();

            //year= 2022-Int32.Parse(year_t);
            year= DateTime.Now.Year-Int32.Parse(year_t);


            //int salary;
           // string salary_t;
            Console.Write("월급 ? ");
            //salary_t = Console.ReadLine();
            int salary = Int32.Parse(Console.ReadLine())*12;

           // salary =  Int32.Parse(salary_t)*12;

            Console.WriteLine("당신의 이름은 {0}입니다.", name);
            Console.WriteLine("당신의 나이는 : {0}세입니다.", year);
            //Console.WriteLine("당신의 연봉은 : \\{0:#,###} 입니다.",salary);
            Console.WriteLine("당신의 연봉은 : {0:C} 입니다.",salary);




        }
    }
}
