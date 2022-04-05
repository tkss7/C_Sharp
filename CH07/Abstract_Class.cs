//Abstract_Class.cs 04/05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH07
{
   abstract class Token //추상클래스는 객체를 생성할 수 없다.
    {
        protected string str;
        public void Hi()
        {
            Console.WriteLine("Hi.");
        }
        public virtual void Name(string _str)
        {
            Console.WriteLine("Token(string _str).");
            str = _str;
        }
        public abstract void Length(); //추상메서드 : 바디가 없는 메서드 , 클래스이름 왼쪽에도 선언해줘야함
    }
    class CommandToken : Token
    {
        public CommandToken(string _str) : base(_str)
        {
            Console.WriteLine("CommandToken(string _str)."+base.str);
        }
        public override void Name(string _str)
        {
            Console.WriteLine("CommandToken."+base.str);
        }
        public override void Length() // 반드시 구현 // 반드시 오버라이드를 써야함
        {
            Console.WriteLine(" Length.");
        }
    }

    class Abstract_Class
    {
        static void Main(string[] args)
        {
            //Token t1 = new Token();
            //t1.Hi();
            //t1.Name();
            //t1.Length();

            Token t2 = new CommandToken();
            t2.Hi();
            t2.Name();
            t2.Length();
        }
    }
}

//
using System;

namespace CH07
{
    abstract class Token
    {
        protected string str;

        public Token()
        {
            Console.WriteLine("Token 빈괄호 생성자");
        }

        public Token(string _str)
        {
            Console.WriteLine("Token(string _str)");
        }

        public void Hi()
        {
            Console.WriteLine("Hi");
        }

        public virtual void Name()
        {
            Console.WriteLine("Token." + str);
        }

        public abstract void Length();            //추상메서드
    }

    class CommandToken : Token
    {
        public CommandToken(string _str)
        {
            Console.WriteLine("CommandToken(string _str)" + base.str);
        }
        public void Name()
        {
            Console.WriteLine("CommandToken" + base.str);
        }

        public override void Length()            //상속 받는 클래스는 추상메서드를 반드시 구현
        {
            Console.WriteLine("Length");
        }

    }

    class Abstract_Class
    {
        static void Main(string[] args)
        {
            /* 추상클래스는 객체 생성 불가
            Token t1 = new Token();
            t1.Hi();
            t1.Name();
            t1.Length();
            Console.WriteLine();
            */
            Token t2 = new CommandToken("시발");
            t2.Hi();
            t2.Name();
            t2.Length();
        }
    }
}