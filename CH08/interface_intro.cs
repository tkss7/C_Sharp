//interface_intro.cs 04/05
using System;

namespace CH08
{
    interface IToken //인터페이스 선언, 구현은 없고 선언만 있다. , 일종의 규격을 제공함
    {// 인터페이스의 빈 메서드를 사용하는 클래스가 채워주는 역할을 한다
        // 변수는 선언 불가
        void Name();
    }
    class Token : IToken
    {
        public void Name()
        {
            Console.WriteLine("Token Name() 메서드");
        }
    }
    class CommandToken :IToken
    {
        public void Name()
        {
            Console.WriteLine(" CommandToken Name() 메서드");
        }
    }

    class interface_intro
    {
        static void Main(string[] args)
        {
            //IToken T1 = new IToken();

            Token t2 = new Token();


        }
    }
}
