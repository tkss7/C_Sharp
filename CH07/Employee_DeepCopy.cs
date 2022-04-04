//Employee_DeepCopy.cs 04/04
using System;

namespace CH07
{
    class Employee
    {
        private string name;       //접근지정자가 없으면 private가 디폴트
        private int salary;
        private string comAddr;
        //이처럼 멤버변수들이 private으로 선언되어있어 외부 함수에서는 접근할 수 없기때문에
        // setData를 public으로 선언하여 외부함수에서 접근이 가능하도록 해준다.
        public Employee()
        {
          
        }

        public Employee(string name, int salary, string comAddr)
        {
            this.name = name;
            this.salary = salary;
            this.comAddr = comAddr;
        }
        public void showData()
        {
            Console.WriteLine("{0}, {1}, {2}", name, salary, comAddr);
        }

        public void AddSalary(int _sudang)
        {
            salary += _sudang;
        }

        public Employee DeepCopy() // this : emp1
        {
            Employee newCopy = new Employee();

            newCopy.name = this.name;
            newCopy.salary = this.salary;
            newCopy.comAddr = this.comAddr;

            return newCopy;
        }

    }
    class Employee_DeepCopy
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee("성춘향", 3700000, "서울시 종로구");
            emp1.showData();

            Employee tmp;
            tmp = emp1; //참조 복사
            tmp.AddSalary(200000);

            tmp.showData();
            emp1.showData();

            Employee emp2 = new Employee("길동이", 3700000, "서울시 강남구");

            Employee tmp2 = emp2.DeepCopy();
            tmp2.AddSalary(500000);
            tmp2.showData();
            emp2.showData();
        }
    }
}