﻿//Array_jagged배열.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class Array_jagged배열
    {
        static void Main(string[] args)
        {
            int[][] grid = new int[2][]; //톱니바퀴 배열
            grid[0] = new int[2];
            grid[1] = new int[4];

            grid[0][0] = 10;
            grid[0][1] = 20;

            grid[1][0] = 100;
            grid[1][1] = 200;
            grid[1][2] = 300;
            grid[1][3] = 400;

            for(int i=0;i<grid[0].Length;i++)
            {
                for (int j = 0; j < grid[i].Length; j++)
                    Console.Write("{0}, ", grid[i][j]);
                Console.WriteLine();
            }    

        }



    }
}
