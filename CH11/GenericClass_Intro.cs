﻿//GenericClass_Intro.cs 04/05
using System;

namespace CH11
{
    class intClass
    {
        private int value;

        public intClass(int _value)
        {
            value = _value;
        }

        public int Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }

    class GenericClass<T>
    {
        private T value;

        public GenericClass()
            {}
        public GenericClass(T _value)
        {
            value = _value;
        }

        public T Value
        {
            get { return this.value; }
            set { this.value = value; }
        }
    }

    class GenericClass_Intro
    {
        static void Main(string[] args)
        {
            intClass num = new intClass(100);
            Console.WriteLine("num : {0}", num.Value);
            num.Value = 200;
            Console.WriteLine("num : {0}", num.Value);
            Console.WriteLine("=================================");

            GenericClass<int> gInt = new GenericClass<int>(200);
            Console.WriteLine("gInt : {0}", gInt.Value);
            gInt.Value = 350;
            Console.WriteLine("gInt : {0}", gInt.Value);
            Console.WriteLine("=================================");

            GenericClass<string> gString = new GenericClass<string>();
            Console.WriteLine("gString : {0}", gString.Value);
            gString.Value = "길동이";
            Console.WriteLine("gString : {0}", gString.Value);
            Console.WriteLine("=================================");

            GenericClass<bool> gBool = new GenericClass<bool>(true);
            Console.WriteLine("gInt : {0}", gBool.Value);
            gBool.Value = false;
            Console.WriteLine("gInt : {0}", gBool.Value);
            Console.WriteLine("=================================");
        }
    }
}
