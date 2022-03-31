using System;
//요즘 컴포넌트 잘 안만든다
//빌드제외 방법 : 우측 하단의 속성창에서 빌드작업 : 없음으로 변경
namespace CH01 // 반드시 필요한 것은 아니다. 그러나 최대한 모든 클래스는 네임스페이스 안에 담아라 가 권장임
{
    class class1
    {
        public static void Main() // public을 안써도 상관없음
        {
            Console.WriteLine("class1 Main() 실행");
        }

    }

    class class2
    {
        public static void Main() // public을 안써도 상관없음
        {
            Console.WriteLine("class2 Main() 실행");
        }

    }
}