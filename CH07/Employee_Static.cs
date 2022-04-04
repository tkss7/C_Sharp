//Employee_Static.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
    class Employee
    {
        private string name;      
        private int salary;
        private string comAddr;

        private static int sudang; //정적멤버 , 클래스 객체변수가 공유

        public Employee() //객체가 생성될 때 마다 실행
        {
            Console.WriteLine("public Employee() called.");
        }
        static Employee() // new 하기전 객체가 처음 생성될 때 한번만 실행
        {
            Console.WriteLine("static Employee() called.");
            sudang = 100000;
        }

        public Employee(string name, int salary, string comAddr)
        {
            this.name = name;
            this.salary = salary;
            this.comAddr = comAddr;
        }
        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary==0 ? salary : salary+sudang, comAddr);
        }
        
        static public void M_Sudang(int _su)
        {
            sudang = _su;
        }


    }
    class Employee_Static
    {
        static void Main()
        {
            Employee.M_Sudang(300000); // 정적 메서드 함수 

            Employee emp1 = new Employee();
            emp1.showData();

            Employee emp2 = new Employee("성춘향",3700000,"서울시 강남구");
            emp2.showData();

        }
    }
}
