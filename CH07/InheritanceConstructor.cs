//InheritanceConstructor.cs
using System;


namespace CH07
{
    class Token
    {
        protected string name;
        public Token()
        {
            name = "UnKnown";
            Console.WriteLine("Token()" + name);
        }

        public Token(string _name)
        {
            name = _name;
            Console.WriteLine("Token(string _name)" + name);
        }

    }

    // this() 생성자 : 현재 클래스의 이웃생성자를 호출
    // base() 생성자 : 기반 클래스의 생성자를 호출

    class CommandToken : Token
    {
        public CommandToken(string _name) : base(_name)
        {
            Console.WriteLine("CommandToken()" + name);
        }
    }
    class InheritanceConstructor
    {
        static void Main(string[] args)
        {
                CommandToken c1 = new CommandToken("길동이");
        }
    }
}
