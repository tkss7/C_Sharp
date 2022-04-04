//Class_Destructor.cs 04/04
using System;
using System.IO;
// C# 구조체 : stack에 저장하므로 작은 데이터를 수행할땐 구조체가 속도가 더 빠르다.
namespace CH07
{
    class SourceFile
    {
        private FileStream src;

        public SourceFile(string name)
        {
            src=File.Open(name,FileMode.Open);
            Console.WriteLine("{0} 를 엽니다.",name);
        }

        ~SourceFile()
        {
            Console.WriteLine("소멸자 호출.");
            src.Close();
        }
    }
    class Class_Destructor
    {
        static void Main(string[] args)
        {
            SourceFile src = new SourceFile("../../../Class_Destructor.cs");


        }
    }
}
