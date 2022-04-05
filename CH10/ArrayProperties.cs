//ArrayProperties.cs  04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class ArrayProperties
    {
        static void Main(string[] args)
        {
            int[] a = new int[10];
            int[,] b = new int[10,10];
            int[,,] c = new int[10,10,10];
            int[][] d = new int[2][];

            d[0] = new int[3];
            d[1] = new int[5];

            Console.WriteLine("a,Rank {0}", a.Rank); // 몇차원 배열인지 보여줌
            Console.WriteLine("b,Rank {0}", b.Rank);
            Console.WriteLine("c,Rank {0}", c.Rank);
            Console.WriteLine("d,Rank {0}", d.Rank);
            Console.WriteLine();

            Console.WriteLine("a.Length {0}", a.Length); // 배열의 크기를 보여줌
            Console.WriteLine("b.Length {0}", b.Length);
            Console.WriteLine("c.Length {0}", c.Length);
            Console.WriteLine("d.Length {0}", d.Length);
            Console.WriteLine("d[0].Length {0}", d[0].Length);
            Console.WriteLine("d[1].Length {0}", d[1].Length);
            Console.WriteLine();

            Console.WriteLine("GetLength(0) {0}", b.GetLength(0));
            Console.WriteLine("GetLength(0) {0}", b.GetLength(1));

        }

    }
}
