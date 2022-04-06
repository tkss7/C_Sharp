using System;

namespace myPersonDll
{
    public class Person //인터널이 디폴트 값임
    {
        public void showDate()
        {
            Console.WriteLine("현재날짜 : {0}", DateTime.Now);
        }
    }
}
