//Employee_PrivateMember.cs 04/05
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
        public void setName(string name)
        {
            this.name = name;
        }
        public void setSalary(int salary)
        {
            this.salary = salary;
        }
        public void setAddres(string comAddr)
        {
            this.comAddr = comAddr;
        }
        public string getName() { return name; }
        public int getSalary() { return salary; }
        public string getAddress() { return comAddr; }
    }
    class Employee_PrivateMember
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.showData();

            Employee emp2 = new Employee("성춘향", 3700000, "서울시 종로구");
            emp2.showData();

            Employee emp3 = new Employee();

            emp3.setName("길동이");
            emp3.setSalary(3700000);
            emp3.setAddres("서울시 서초구");

            emp3.showData();

        }
    }
}