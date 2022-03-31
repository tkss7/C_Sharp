using System;
using GreetingWorld; //이렇게 설정하면
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

namespace HelloWorld
{
    partial class Program2 // 클래스 파일이 달라도 클래스명이 같으면 같은 클래스로 보겠다.
    {
        public static void Main()
        {
            Console.WriteLine("namespace, class, method 구분");

            GoodMorning(); //같은 클래스의 메서드

            Program3.GoodBye();
            Greeting.GrretingShow1();

            GoodNight(); //partial 키워드 

            GreetingWorld.Greeting2.GreetingShow2(); // 다른 namespace의 다른 클래스의 메소드 호출

            Greeting2.GreetingShow2(); // using GreetingWorld; 을 사용하면 이처럼 사용 가능하다.
        }

        public static void GoodMorning()
        {
            Console.WriteLine("안녕하세요~");
        }

    } // class Program2 end

    class Program3
    {
        public static void GoodBye()
        {
            Console.WriteLine("안녕히 가세요~");
        }
    }

}
