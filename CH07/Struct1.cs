//Struct1.cs 04/04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//구조체 생성자는 
namespace CH07
{
    struct Employee
    {
        private string name;
        private int salary;
        private DateTime birth;

        //public Employee() //구조체는 빈괄호 생성자를 만들 수 없다.
        //{
        //    Console.WriteLine("Employee() called.");
        //}

        public Employee(string _name, int _sal, DateTime _birth) 
        {
            Console.WriteLine("Employee(string _name, int _sal, DateTime _birth) called.");
            name = _name;
            salary = _sal;
            birth = _birth;
        }

        //public Employee(string _name, int _sal) //구조체 생성자는 부분 초기화를 허용하지 않는다.
        //{
        //    Console.WriteLine("Employee(string _name, int _sal) called.");
        //    name = _name;
        //    salary = _sal;
            
        //}

        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2} ", name, salary, birth);
        }
    }


    class Struct1
    {
        static void Main(string[] args)
        {
            Employee e1 = new Employee(); // 구조체이므로 heap 이 아닌 stack에 저장된다.

            e1.showData();

            Employee e2 = new Employee("홍길동",2700000,DateTime.Parse("2022-04-01")); 
            e2.showData();

            //Employee e3 = new Employee("홍길동", 2700000);
            //e3.showData();

            //Employee e4; // 할당되지 않은 구조체 변수 : error
            //e4.showData();


        }
    }
}
