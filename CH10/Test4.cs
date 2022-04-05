using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Test4
    {
        static int Input(string[]s1, string[] s2, int[] n1)
        {
            int i, count=0;
                for (i = 0; i < 5; i++)
                {
                    Console.Write("이름은 ? ");
                    s1[i] = Console.ReadLine();
                    if(string.Compare(s1[i],"end",true)==0)
                    {
                        count = i - 1; // 개수니깐 , i는 0부터 시작하기때문에 +1을 해줘야하는데 그러면 결국 i를 반환하는게 맞다.

                        break;
                    }

                    Console.Write("월급은 ? ");
                    n1[i] = Int32.Parse(Console.ReadLine());

                    Console.Write("주소는 ? ");
                    s2[i] = Console.ReadLine();
                }
                
            
            return i;
        }
        static void Main(string[] args)
        {
            string[] names=new string[5];
            string[] comAddr=new string[5];
            int[] salary=new int[5];
            int size, salTot = 0;

            size = Input(names, comAddr, salary);
            for(int i=0;i<size;i++)
            {
                Console.WriteLine("{0}, {1:N0}, {2} ", names[i], salary[i], comAddr[i]);
                salTot += salary[i];
            }
            Console.WriteLine("월급의 평균 : {0}", salTot / size);


        }
    }

}
