//Nested_Class.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
    class firstClass
    {
        private string name;

        public firstClass()
        {
            name = "noName";
        }

        public void showData()
        {
            Console.WriteLine("name : {0}", name);
        }

        public void Rename(string _name)
        {
            secondClass rName = new secondClass();
            rName.SetName(ref name, _name);
        }

        class secondClass //클래스 중첩
        {
            public void SetName(ref string _refname, string _name)
            {
                _refname = _name; //중첩된 클래스 메서드는 상위클래스의 private 멤버에 바로 접근 가능

            }
        }

    }

    class Nested_Class
    {
        static void Main(string[] args)
        {
            firstClass my = new firstClass();
            my.showData();

            my.ReName("홍길동");
            my.showData();
        }
    }
}
