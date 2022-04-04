//Virtual_Class.cs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//sealed : 메소드에 쓰면 오버라이딩 못하게 하겠다.
//sealed : 클래스에 쓰면 상속 못받게 하겠다.
//partial : 분할 클래스
namespace CH07
{
    class Token
    {
        public virtual void Name()
        {
            Console.WriteLine("Token.");
        }
    }

    class CommandToken : Token
    {
        public override void Name()
        {
            //base.Name();
            Console.WriteLine("CommandToken.");
        }
    }

    class OnLineCommandToken : CommandToken
    {
        public new void Name() //method override (메서드 재정의)
        {
            //base.Name();
            Console.WriteLine("OnLineCommandToken.");
        }
    }
    // vritual 과 override를 써야 다형성이다.
    // 가상함수를 써서 overide할ㄲ면(후기 바인딩)  override
    // 만약 override하고 싶지 않다면 new 키워드 입력
    class Virtual_Class
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            Token t2 = new CommandToken();
            Token t3 = new OnLineCommandToken();

            t1.Name();
            t2.Name();
            t3.Name();


        }
    }
}
