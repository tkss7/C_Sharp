//ISendable_Interface.cs 04/05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08
{
    interface ISendable
    {
        void Send(string msg1, string msg2, string msg3 = "");

    }
    class EMail:ISendable
    {

        public void Send(string s1, string s2, string s3="")
        {
            Console.WriteLine("EMail {0} to {1}", s1, s2);
        }
        
    }

    class SMS : ISendable
    {
        public void Send(string s1, string s2, string s3 = "")
        {
            Console.WriteLine("phone {0} to {1}, {2}", s1, s2, s3);
        }
    }

    class ISendable_Interface
    {
        static void Main(string[] args)
        {
            EMail e1 = new EMail();
            e1.Send("길동님", "hong@naver.com");

            SMS s1 = new SMS();
            s1.Send("나리님","010-001-1234","배송완료~");
        }
    }
}
