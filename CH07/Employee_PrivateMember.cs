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
            name = "김영빈";
            salary = 3500;
            comAddr = "인천광역시 서구 원적로 47번길 6";
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
    }
    class Employee_PrivateMember
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.showData();

            Employee emp2 = new Employee("성춘향", 3700000, "서울시 종로구");
        }
    }
}