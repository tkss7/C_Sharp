//BaseAndDerived2.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
    class Base
    {
        protected string name;
        protected int salary;

        public Base()
        {
            name = "Base";
            salary = 0;
        }

        public void BaseMethod()
        {
            Console.WriteLine("BaseMethod() : {0}, {1}", name, salary);
        }
    }

    class Derived : Base
    {
        private string name;
        private string telno;

        public Derived()
        {
            base.name = "Base1";
            this.name = "Derived";
            telno = "010-001-1234";
            salary = 3500000;
        }

        public void DerivedMethod()
        {
            Console.WriteLine("DerivedMethod() : {0}, {1}, {2}, {3}",base.name,base.salary,this.name,this.telno);
        }

    }

    class BaseAndDerived2
    {
        static void Main(string[] args)
        {
            Base b1 = new Base();
            b1.BaseMethod();

            Derived d1 = new Derived();
            d1.DerivedMethod();
        }
    }
}
