using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication10
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = new int[5];
            Random ran = new Random();
            for (int i = 0; i < 4; i++)
            {
                A[i] = ran.Next(10);
                Console.Write("{0}\t", A[i]);
            }
            Console.WriteLine();
           bool g = false;
            for (int i = 0; i< 4; i++)
            {
            for (int j = 0;j<4;j++)
            {
                 if ((A[i] == A[j])&&(i!=j))
            {
            g=true;
            }
                }
            }
if (g==true)
    {
            Console.WriteLine("Yes");
    }
    else
    {
    Console.WriteLine("No");
    }
            Console.ReadKey();
        }
    }
}
