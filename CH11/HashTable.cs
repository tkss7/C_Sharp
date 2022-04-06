//HashTable.cs
using System;
using System.Collections;
// 해쉬테이블과 딕셔너리 차이 : 딕셔너리가 제네릭이므로 속도가 더 빠르다.
namespace CH11
{
    class HashTableProgram
    {
        public static void DataShow(Hashtable htList)
        {
            // 컬렉션에서 반복하는 반복자를 반환
            IDictionaryEnumerator myEnum = htList.GetEnumerator();

            while (myEnum.MoveNext()) //데이터가 있으면 MoveNext가 참임
                Console.WriteLine("{0}, {1}", myEnum.Key, myEnum.Value);

        }
        static void Main(string[] args)
        {
            Hashtable nameHT = new Hashtable();

            nameHT.Add("홍길동", 3500000);
            nameHT.Add("이몽룡", 2500000);
            nameHT.Add("성춘향", 5700000);
            nameHT.Add("진달래", 2900000);

            DataShow(nameHT);

            bool ret = nameHT.ContainsKey("이몽룡"); //찾으면 true
            Console.WriteLine("이몽룡 존재여부 : {0} ", ret);
            Console.WriteLine();

            nameHT.Remove("이몽룡"); // 없으면 오류없이 제거되지 않고 출력됨
            DataShow(nameHT);

            //컬렉션의 크기, 열거자 등 사용
            ICollection myKey = nameHT.Keys;
            foreach (object item in myKey)
                Console.Write("{0}, ", item);
            Console.WriteLine();

            ICollection myValue = nameHT.Values;
            foreach (object item in myValue)
                Console.Write("{0}, ", item);
            Console.WriteLine();


        }
    }
}
