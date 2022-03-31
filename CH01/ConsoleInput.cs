//ConsoleInput.cs
using System;

//Console.ReadLine() : 줄단위로 받음
//Console.Read() : 한글자만 받음
namespace CH01
{
    class ConsoleInput
    {
        public static void Main()
        {

            Console.Write("이름 : ");
            string name = Console.ReadLine(); //공백을 포함함

            Console.WriteLine("이름은 {0} 입니다", name);

            Console.Write("당신의 성은 ? ");
            char name2 = (char)Console.Read(); //공백을 포함함

            Console.WriteLine("당신의 성은 {0} 입니다", name2);
            Console.ReadLine(); // 버퍼에 남아있는 엔터값 버리려고 씀

            Console.Write("나이 ? ");
            string tmp = Console.ReadLine(); // 문자열로 취급
            //int age = Int32.Parse(tmp); // 문자열을 정수로 변환
            //int age = int.Parse(tmp);
            int age = Convert.ToInt32(tmp); //tmp를 int32로 변환해 주겠다.

            Console.WriteLine("{0}의 나이는 {1} 입니다", name, age);


            Console.WriteLine(DateTime.Now);
            Console.WriteLine(DateTime.Now.Year);
            Console.WriteLine(DateTime.Now.Month);
            Console.WriteLine(DateTime.Now.Day);
            Console.WriteLine("{0}시",DateTime.Now.Hour);
            Console.WriteLine("{0}분",DateTime.Now.Minute);
            Console.WriteLine("{0}초",DateTime.Now.Second);

            Console.Write("생년월일 ? ");
            //DateTime birth = Console.ReadLine();
            string tmp2 = Console.ReadLine();
            //DateTime birth = DateTime.Parse("1988-05-01"); // 이것도 가능
            DateTime birth = DateTime.Parse(tmp2);

            Console.WriteLine("생일은 {0} 입니다. ", birth); // 생일은 2022-10-21 오전 12:00:00 입니다.
            Console.WriteLine("생일은 {0} 입니다. ", birth.ToShortDateString());// 생일은 2022 - 10 - 21 입니다.
            Console.WriteLine("생일은 {0} 입니다. ", birth.Year); 
        }
    }
}
