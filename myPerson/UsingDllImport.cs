using System;
using System.Runtime.InteropServices;

//dll 파일을 c# project의 CH11_제너릭\bin\Debug 디렉토리에 복사한다.

namespace UsingDllImport
{
    class CRT
    {
        [DllImport("msvcrt.dll")]  //C 런타임 라이브러리
        public static extern int puts(string text);

        /*
        //작성한 C++ Dll 
        [DllImport("myDll.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static int sum(int a, int b);

        [DllImport("myDll.dll", CallingConvention = CallingConvention.Cdecl)]
        extern public static void MyMessage(char[] ch);
        */       
    }

    class Win32API
    {
        [DllImport("user32.dll")]
        public static extern int MessageBox(int hWnd, string text, string caption, uint type);
           

        //[DllImport("kernel32.dll")]     //두가지 중 한가지 선택가능하다
        //public static extern uint WinExec(string cmdLine, uint cmdShow);

        [DllImport("kernel32.dll", EntryPoint = "WinExec")]
        public static extern uint ProcessStart(string cmdLine, uint cmdShow);
    }



    class Program
	{
		static void Main(string[] args)
		{
            //1. C 런타임 라이브러리 함수 사용
			CRT.puts("이것은 콘솔에 문자열을 출력한 것입니다.");
/*
            //2. myDll_P.dll 사용하기
            int tot = CRT.sum(1, 3);
            Console.WriteLine("sum : {0}", tot);

            String msg = "multi campus !!";
            char[] MsgArray = msg.ToCharArray();
            CRT.MyMessage(MsgArray);
            Console.WriteLine("===================\n");
*/

            //3. Windows API 실행하기
            Win32API.MessageBox(0, "이것은 Win32 API 메시지상자입니다.",
                                   "Win32API", 0);

            //Win32API.WinExec("calc.exe", 1);
            Win32API.ProcessStart("notepad.exe", 1);
        }
	}
}
