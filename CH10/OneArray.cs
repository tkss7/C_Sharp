//OneArray.cs 04/01
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CH10
{
    class OneArray
    {
        static void scoreInput(ref int[]score)
        {
            
            for(int i=0;i<score.Length;i++)
            {
                Console.Write("{0}, 성적 ? ",i+1);
                score[i] = Int32.Parse(Console.ReadLine());
            }
            Console.WriteLine();
        }

        static void scoreOutput(ref int[] score)
        {

            for (int i=0;i<score.Length;i++)
            {
                Console.Write("{0} ", score[i]);
            }
            Console.WriteLine();

        }

        static void scoreCalc(int[] score)
        {
            int max, min, sum = 0;
            max = score[0];
            min = score[0];

            for(int i=0;i<score.Length;i++)
            {
                sum += score[i];
                if (max < score[i])
                    max = score[i];
                if (min > score[i])
                    min = score[i];
            }

            Console.WriteLine("sum : {0}", sum);
            Console.WriteLine("avg : {0}", (float)sum/score.Length);
            Console.WriteLine("max : {0}", max);
            Console.WriteLine("min : {0}", min);


        }

        static void Main(string[] args)
        {
            int[] score = new int[5];

            scoreInput(ref score);
            scoreOutput(ref score);
            scoreCalc(score);
        }
    }
}
