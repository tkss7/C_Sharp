//ObjectTypeCast.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
    class Token
    {
        public void Name()
        {
            Console.WriteLine("Token.");
        }
    }

    class CommandToken : Token
    {
        public void Name()
        {
            //base.Name();
            Console.WriteLine("CommandToken.");
        }
    }

    class OnLineCommandToken : CommandToken
    {
        public void Name() //method override (메서드 재정의)
        {
            //base.Name();
            Console.WriteLine("OnLineCommandToken.");
        }
    }

    class ObjectTypeCast
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            t1.Name();

            CommandToken c1 = new CommandToken();
            c1.Name();

            // 파생클래스 객체가 생성되면 기반클래스 오버라이드 된 메서드는 가려진다.
            OnLineCommandToken oc1 = new OnLineCommandToken();
            oc1.Name();
            Console.WriteLine();

            Token t2, t3;
            t2 = new CommandToken(); //UpCast
            t3 = new OnLineCommandToken();

            // 파생클래스 객체가 기반클래스 객체변수에 대입되면 기반클래스 메서드가 불려진다.
            t2.Name();
            t3.Name();

             //CommandToken c2 = new Token(); //DownCast = 오류

            if(t2 is CommandToken) // 형변환이 가능한지 묻는다, 참이면 true, 거짓이면 false == 이걸 많이쓴대요
            {
                c1 = (CommandToken)t2;
                c1.Name();
            }
                                        //실패하면 null을 반환
            OnLineCommandToken oc2 = t3 as OnLineCommandToken; // as : 형 변환함 
            if (oc2 != null)
                oc2.Name();


        }

    }
}
