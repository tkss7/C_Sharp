//형식매개변수_제약.cs 04/06
using System;

namespace ConstraintsOnTypeParameters
{
    class StructArray<T> where T : struct  //값형식
    {   // where : 템플릿에 제어를 건다. where T : struct : 스택에 저장하는 값형식만 저장한다.
        //객체 생성을 하면서 생성자에 넘겨준 3에 의해 
        //a 객체안의 배열 타입의 속성인 Array 속성의 배열 크기를 결정 한다.
        public T[] Array { get; set; }
        public StructArray(int size)
        {
            Array = new T[size];
        }
    }

    class RefArray<T> where T : class   //참조형식만 받겠다.
    {
        public T[] Array { get; set; }
        public RefArray(int size)
        {
            Array = new T[size];
        }
    }

    class myNum
    {
        public int num { get; set; }

        public void Show()
        {
            Console.WriteLine("myNum: {0} ", num);
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            StructArray<int> a = new StructArray<int>(3);
            a.Array[0] = 100;
            a.Array[1] = 200;
            a.Array[2] = 300;

            for (int i = 0; i < a.Array.Length; i++)
                Console.Write("{0}, ", a.Array[i]);
            Console.WriteLine("\n");

            RefArray<myNum> a2 = new RefArray<myNum>(3); // 포인터배열 3개가 선언된 것과 같음
            a2.Array[0] = new myNum();
            a2.Array[1] = new myNum();
            a2.Array[2] = new myNum();

            a2.Array[0].num = 10;
            a2.Array[1].num = 11;
            a2.Array[2].num = 12;

            for (int i = 0; i < a2.Array.Length; i++)
                //a2.Array[i].Show();
                Console.Write("num : {0}, ", a2.Array[i].num);
            Console.WriteLine("\n");

        }
    }
}