//Employee_Auto_Property.cs 04/05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08
{

    class Employee
    {
        //private string name;       //접근지정자가 없으면 private가 디폴트
        private int salary;
        private string comAddr;
        //이처럼 멤버변수들이 private으로 선언되어있어 외부 함수에서는 접근할 수 없기때문에
        // setData를 public으로 선언하여 외부함수에서 접근이 가능하도록 해준다.
        public Employee()
        {
        }

        public string name // auto ProPerty 멤버
        {
            get;
            set;
        }

        public int Salary
        {
            get { return salary; }
            set
            {
                if (value >= 0 && value <= 7000000)
                    salary = value;
                else
                {
                    Console.WriteLine("월급은 0~7000000 를 입력!!");
                    salary = 0;
                }
            }
        }

        public string Address
        {
            get { return comAddr; }
            set { comAddr = value; }
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

    } // class Employee end

    class Employee_Auto_Property
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            emp1.showData();

            Employee emp2 = new Employee("성춘향", 3700000, "서울시 종로구");
            emp2.showData();

            Employee emp3 = new Employee();

            emp3.name = "길동이";
            emp3.Salary = 3700000;
            emp3.Address = "부산시 해운대구 100";

            Employee emp4 = new Employee()
            {
                name = "몽룡이",
                Salary = 2800000,
                Address = "서울시 종로구 200";
            }

        }
    }
}
