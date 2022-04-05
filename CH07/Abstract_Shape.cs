//Abstract_Shape.cs 04/05
using System;

/*
[Rectangle] Position = (5, 5), size = (30 40)
[Circle] Position = (150, 30), Radius= (40)
*/

namespace AbstractShape
{
    abstract class Point  //추상 클래스
    {
        protected double xpos;
        protected double ypos;

        public Point()
        {
            xpos = ypos = 0;
        }

        public Point(double _x, double _y)
        {
            xpos = _x;
            ypos = _y;
        }

        public abstract void Draw();  //추상메서드
    }

    class Rectangle : Point
    {
        private double width;
        private double height;

        public Rectangle()
        {
            width = height = 100.0;
        }

        public Rectangle(double _x, double _y, double _width, double _height) : base(_x, _y)
        {
            width = _width;
            height = _height;

        }

        public override void Draw()
        {
            Console.WriteLine("[Rectangle] Position = ({0}, {1}), size = ({2} {3})", xpos, ypos, width, height);
        }
    }

    class Circle : Point
    {
        private double radius;

        public Circle()
        {
            radius = 100.0;
        }

        public Circle(double _x, double _y, double _radius):base(_x,_y)
        {
            radius = _radius;
        }


        public override void Draw()
        {
            Console.WriteLine("[Circle] Position = ({0}, {1}), Radius= ({2})", xpos, ypos, radius);
        }
    }

    class ConsoleApplication
    {
        static void Main(string[] args)
        {
            
            Point r1 = new Rectangle(5, 5, 30, 40);
            r1.Draw();

            Point c1 = new Circle(150, 30, 40);
            c1.Draw();

            Point[] Arr = new Point[5];

            Arr[0]= new Rectangle(5, 5, 30, 40);
            Arr[1]= new Circle(150, 30, 40);
            Arr[2]= new Rectangle(50, 45, 3, 44);
            Arr[3]= new Circle(140, 37, 47);
            Arr[4]= new Rectangle(9, 7, 35, 86);

            for(int i=0;i<Arr.Length;i++)
            {
                if (Arr[i] != null)
                    Arr[i].Draw();
            }
            for (int i = 0; i < Arr.Length; i++)
            {
                if (Arr[i] != null)
                    Arr[i] = null; // 빠른 delete를 유도한다 참조한 것이 모두 null이면 더이상 사용하지 않는다고생각해 해제함 = 해제를 유도함
            }
        }
    }
}