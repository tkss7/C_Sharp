//Indexer_Overloading.cs 04/05
using System;
using System.Collections;


namespace CH08
{
    class NickName
    {
        public Hashtable name = new Hashtable(); //key value 구성
        
        public string this[int index]
        {
            get { return (string)name[index]; }
            set { name[index] = value; }
        }
        public string this[string index]
        {
            get { return (string)name[index]; }
            set { name[index] = value; }
        }
        public string this[char index]
        {
            get { return (string)name[index]; }
            set { name[index] = value; }
        }
    }

    class Indexer_Overloading
    {
        static void Main(string[] args)
        {
            NickName Name = new NickName();
            Name[0] = "김원선";
            Name[1] = "홍길동";

            Name["첫번째"] = "kim WeonSun";
            Name["두번째"] = "Hong Gildong";

            Name['A'] = "강사";
            Name['B'] = "선비";


            Console.WriteLine(Name[0]);
            Console.WriteLine(Name["첫번째"]);
            Console.WriteLine(Name['A']);

            foreach (DictionaryEntry item in Name.name)
                Console.WriteLine("{0}, {1}", item.Key, item.Value);


        }
    }
}
