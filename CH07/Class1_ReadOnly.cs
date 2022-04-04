//Class1_ReadOnly.cs 04/04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
    class Car
    {
        private readonly int count = 5; //const지만 생성자에서 딱 한번 수정의 기회를 준다.
        private const int speed = 10;

        public Car()
        {

        }
        public Car(int _count)
        {
            count = _count;
            //speed = _count; // 불가 : 상수는 선언과 동시에 한 초기화가 끝이다.
        }

        public void showData()
        {
            Console.WriteLine("count : {0} ", count);
            Console.WriteLine("speed : {0} ", speed);
        }
    }
    class Class1_ReadOnly
    {
        static void Main(string[] args)
        {
            Car c1 = new Car();
            c1.showData();

            Car c2 = new Car(20);
            c2.showData();
        }
    }
}
