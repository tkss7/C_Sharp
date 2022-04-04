//Class_Constructor.cs 04/04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
    class Date
    {
        private int yy;
        private int mm;
        private int dd;

        public Date() : this(2022,1,1) //this() : 이웃 생성자 호출
        {
            Console.WriteLine("Date()");
            //yy = DateTime.Now.Year;
            //mm = DateTime.Now.Month;
            //dd = DateTime.Now.Day;
        }

        public Date(int yy, int _m, int _d)
        {
            Console.WriteLine("Date(int _y, int _m, int _d)");
            this.yy = yy; // C++에서는 this-> 였지만, C#에서는 포인터를 못쓰므로 this. 임 
            mm = _m;
            dd = _d;
        }

        public void showData()
        {
            Console.WriteLine("{0}년, {1}월, {2}일 ", yy, mm, dd);
        }

    }
    class Class_Constructor
    {
        static void Main(string[] args)
        {
            Date d1 = new Date(); // new를 하면 생성자불러서 초기화를 시킨다.
            d1.showData();

            Date d2 = new Date(2022, 4, 5);
            d2.showData();

            Date d3 = new Date();
            d3.showData();

        }
    }
}
