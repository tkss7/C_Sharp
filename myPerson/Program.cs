using System;
using myPersonDll;
namespace myPerson
{
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.showDate();
        }
    }
}
// dll 추가 = 프로젝트명-> 우클릭-> 추가-> COM참조 ->찾아보기 ->적용 후 맨위에 using 네임스페이스명; 