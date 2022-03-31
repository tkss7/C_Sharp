//Enumeration.cs //나열형
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//type은 메서드안에 포함될 수 없다. type : ex) enum , class 등등
//type은 type을 포함 할 수 있다.
namespace CH01
{
    enum Color
    {
        Red,
        //Red=100,  //값을주면 그것부터 시작함
        Green,
        Blue
    }
    class Enumeration
    {
        public static void Main()
        {
            const float PI = 3.14159F; //상수화

            Console.WriteLine("PI : {0} ", PI);
            //PI = 1.5F; //상수화 되어서 안됨

            Color color1 = Color.Red; //C++에서는 숫자가 나옴 , C #에서는 값이 나옴
            Console.WriteLine("color1 : {0}", color1);
            Console.WriteLine("color1 : {0}", (int)color1); //정수형으로 변환

            Color color2 = Color.Green; // enum 범위 안에 것만 받겠다.
            Color color3 = (Color)2;
            Console.WriteLine("color2 : {0}", color2);
            Console.WriteLine("color3 : {0}", color3);



        }
    }
}
