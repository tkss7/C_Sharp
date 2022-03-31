//SimpleType1.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimitiveTypes
{
    class SimpleType1
    {
        public static void Main()
        {
            //Integet type
            SByte sbyte1 = -127; // sbyte = -128~ 127
            byte byte2 = 250; // byte = 0~255
            Int32 int2 = 3500000;
            long longInt4 = 2700000000; // 내부적으로 CTS 형식으로 바뀜
            int 나이 = 30; //한글 변수 가능


            Console.WriteLine(sbyte1);
            Console.WriteLine(byte2);
            Console.WriteLine(int2);
            Console.WriteLine(longInt4);
            Console.WriteLine(나이);

            //실수형 type
            float float5 = 1.123F; // float와 double의 자동 형변환이 불가능하다. 접미사 규칙 필수
            double double6 = 3.14159;
            decimal decimal7 = 123456789.1456M; // 16byte의 크기의 데시말 타입

            Console.WriteLine(float5);
            Console.WriteLine(double6);
            Console.WriteLine(decimal7);
            Console.WriteLine();

            //문자형 type
            char char8 = 'A';
            string string9 = "campus";
            bool bool10 = true;

            Console.WriteLine(char8);
            Console.WriteLine(string9);
            Console.WriteLine(bool10);
            Console.WriteLine();
            
            //자료형의 크기만 sizeof()로 확인
            Console.WriteLine("{0}, {1}, {2}",sizeof(bool),sizeof(char),sizeof(decimal)); // 1,  2,   16

            //변수형의 크기는 sizeof()로 확인 불가
            //Console.WriteLine("{0}, {1}, {2}", sizeof(bool10), sizeof(char8), sizeof(decimal7));
        }
    }
}
