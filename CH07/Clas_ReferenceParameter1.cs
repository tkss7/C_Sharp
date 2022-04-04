//Clas_ReferenceParameter1.cs 04 / 04
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
    class Point
    {
        public double x;// 멤버변수
        public double y;
    }

    class Clas_ReferenceParameter1
    {
        static void PassByVal(Point _c1)
        {
            Console.WriteLine("PassByVal : {0}, {1}", _c1.x, _c1.y);
            _c1.x++;
            _c1.y++;

            _c1 = new Point();

        }

        static void PassByRef(ref Point _c1) // 참조자이므로 _c1 = new Point(); 하면 기존주소가 아닌 비어있는 다른주소를 가리킴
        {
            Console.WriteLine("PassByVal : {0}, {1}", _c1.x, _c1.y);
            _c1.x++;
            _c1.y++;

            _c1 = new Point();
        }

        static void PassByOut(out Point _c2) // out에 있는 메모리로 저장되어 넘어간다
        {

            _c2 = new Point(); // 주소 할당받아 out으로 저장하여 넘김

            _c2.x = 5.0;
            _c2.y = 5.5;

        }

        static void Main(string[] args)
        {
            Point c1 = new Point();
            c1.x = 1.0;
            c1.y = 1.5;

            PassByVal(c1);
            Console.WriteLine("PassByVal : {0}, {1}", c1.x, c1.y);


            PassByRef(ref c1);
            Console.WriteLine("PassByRef : {0}, {1}", c1.x, c1.y);

            Point c2;
            PassByOut(out c2);
            Console.WriteLine("PassByOut : {0}, {1}", c2.x, c2.y);

        }
    }
}
