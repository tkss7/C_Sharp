//Index_Intro.cs 04/05
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH08
{
    class StringList
    {
        string[] list = new string[10];

        public string this[int index] //this가 indexer 다
        {
            set { list[index] = value; }
            get { return list[index]; }
        }

        public int length()
        {
            return list.Length; //여기서 배열임으로 lengh를 메소드로 만들어 사용
        }
    }
    class Indexer_Intro
    {
        static void Main(string[] args)
        {
            StringList myList = new StringList(); //얘는 변수지 배열이 아니라서 length를 직접적으로 못함

            myList[0] = "하나";
            myList[1] = "two";
            myList[2] = "hello world";

            Console.WriteLine("myList.length() : {0}", myList.length());

            for(int i=0;i<myList.length();i++)
            {
                if (myList[i] != null)
                    Console.WriteLine(myList[i]); //get
            }


        }
    }
}
