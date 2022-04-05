//TwoArray.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class TwoArray
    {
        static void Main(string[] args)
        {
            int[,] grid = new int[2, 3];

            grid[0, 0] = 10;
            grid[0, 1] = 20;
            grid[1, 0] = 30;
            grid[1, 1] = 40;

            for(int i=0;i<2;i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(" {0}, ", grid[i, j]);
                Console.WriteLine();
            }

            int[,] grid2 = new int[2, 3]
            {
                {1,2,3 },
                {4,5,6 }
            };

            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 3; j++)
                    Console.Write(" {0}, ", grid2[i, j]);
                Console.WriteLine();
            }

            /*
            int[,] grid3 = new int[2, 3] //배열초기화는 배열원소의 수는 배열행열 수와 같아야한다.
            { //ex) 2x3 크기인데 2x2 크기로 주면 오류뜸
                {1,2},
                {4,5}
            };
            */


            //int[,] grid4 = new int[2, 3]
            //{
            //    {1,2,3 ,4,5,6 } //배열 초기화는 행단위 {}를 생략할 수 없다.
            //};




        }
    }
}
