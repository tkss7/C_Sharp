//Property_읽기전용.cs 04/05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08
{
    class Person
    {
        private readonly DateTime birth; // 한번의 수정기회를 생성자에서 주는 함수

        public Person(DateTime _birth)
        {
            birth = _birth;
        }

        public int Age
        {
            get
            {
                return DateTime.Now.Year - birth.Year;
            }
        }

    }
    class Property_읽기전용
    {
        static void Main(string[] srgs)
        {
            DateTime birthday = new DateTime(1972,01,01);

            Person p1 = new Person(birthday);
            Console.WriteLine("나이 : {0} ", p1.Age);

        }
    }
}
