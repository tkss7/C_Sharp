//Interface_다중상속.cs 04/05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08
{
    interface IToken1
    {
        void Name();    
    }

    interface IToken2
    {
        void Name();
        void Accept();
    }
    
    class Token:IToken1,IToken2
    {
        void IToken1.Name()
        {
            Console.WriteLine("IToken1.Name() 메서드");
        }
        void IToken2.Name()
        {
            Console.WriteLine("IToken2.Name() 메서드");
        }

        public void Accept()
        {
            Console.WriteLine("IToken2.Accept() 메서드");
        }
    }

    class Interface_다중상속
    {
        static void Main(string[] args)
        {
            Token t1 = new Token();
            t1.Accept();

            IToken1 t2 = t1; // t1을 IToken1타입으로 형변환 하여 t2에 저장
            t2.Name(); // 이러면 Name만 노출함

            IToken2 t3 = t1; // t1을 IToken2타입으로 형변환 하여 t3에 저장
            t3.Name();
            t3.Accept();
        }
    }
}
