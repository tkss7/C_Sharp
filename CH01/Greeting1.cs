using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld //클래스 파일이 달라도 네임스페이스 명이 다르면 같은 공간으로 인식한다.
{
    class Greeting
    {
        public static void GrretingShow1()
        {
            Console.Write("같은 namespace, 다른 클래스 "); // 일반적인 printf
            Console.WriteLine("같은 namespace, 다른 클래스 "); // 끝에 \n 추가된 버전의 printf
            
        }
    }

    partial class Program2 // 클래스 파일이 달라도 클래스명이 같으면 같은 클래스로 보겠다.
    {
        public static void GoodNight()
        {
            Console.WriteLine("안녕히 주무세요~");
        }
    }
}
