//BaseAndDerived.cs 04/04
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

        public void BaseMethod()
        {
            name = "Base";
            Console.WriteLine("BaseMethod() : {0}", this.name);
        }
    }
    
    class Derived : Base
    {
        public void DerivedMethod()
        {
            name = "Derived";
            Console.WriteLine("DrivedMethod() : {0}", this.name);
        }

    }

    class BaseAndDerived : Base
    {
        static void Main(string[] args)
        {

            Base b1 = new Base();
            b1.BaseMethod();

            Derived d1 = new Derived();
            d1.BaseMethod();
            d1.DerivedMethod();
        }

    }
}
