//ConsoleInput.cs
using System;
// Ctrl + X : 한줄지우기
// Ctrl + D : 그 줄복사
// Ctrl + W : 단어 선턱
// Ctrl + SPACE : 목록 표시

namespace CH01
{
    class ConsoleOutput
    {
        public static void Main()
        {
//WriteLine
            Console.WriteLine(100);
            Console.WriteLine("hello");
            Console.WriteLine('가');

//Parameter
            Console.WriteLine("{0}, {1}, {2} ", 100, 200, 300);
            Console.WriteLine("{0}, {1}, {1}, {1}, {2} ", 100, 200, 300);
            Console.WriteLine();


            //Alignement or Format
            Console.WriteLine("{0, -10}",999);
            Console.WriteLine("{0, 10}",999);
            Console.WriteLine("{0:C}",123456789);// 화폐단위로 값을 표시
            Console.WriteLine("{0:N}",123456789); // 3자리마다 컴마
            Console.WriteLine("{0:N0}",123456789); // 3자리마다 컴마, 0표시
            Console.WriteLine("{0:X}",123456789);  // 16진수로 데이터 출력
            Console.WriteLine();

            Console.WriteLine("{0}", 0);
            Console.WriteLine("{0:#,###}", 0); //0을 찍지 않겠다
            Console.WriteLine("{0:#,##0}", 0); // 0을 찍겠다.
            Console.WriteLine("{0:#,###}", 123456789);
            Console.WriteLine("{0:#,##0}", 123456789);
            Console.WriteLine();

            decimal tmp = 20.5M;
            string s = string.Format("온도 {0} 입니다.", tmp); // Fomat으로 원하는 문자열을 담아 둘 수 있다.
            //Format : 단순 문자열을 함수처럼 만들어 보관함, 사용가능
            Console.WriteLine(s);

//Special string
            //Console.WriteLine("\\server\share"); //\를 문자로 찍고 싶으면 \를 하나 더 줘서 해제시킨다 : \\
            Console.WriteLine("\\\\server\\share"); //\\server\share 와 같은 경로
            Console.WriteLine(@"\\server\share"); //\\server\share 와 같은 경로
            // @ : @뒤의 더블코트안의 글자들은 전부 글자로만 표시한다.






        }
    }
}
