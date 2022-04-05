//ParamParameter.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH06
{

    class ParamParameter
    {

        static int AddList(params int[] arr) //params int[] arr :  배열의 개수를 동적으로 할당해주는 역할
        {
            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
                sum += arr[i];

            return sum;
        }

        static void Main(string[] args)
        {
            int[] array1 = { 1, 2, 3, 4, 5 };
            int[] array2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int ret;
            ret = AddList(array1);
            Console.WriteLine("ret : {0} ", ret);

            ret = AddList(array2);
            Console.WriteLine("ret : {0} ", ret);

            ret = AddList(10, 20, 30, 40, 50, 60, 70);
            Console.WriteLine("ret : {0} ", ret);
        }
    }
}
