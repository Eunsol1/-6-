using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace ConsoleApplication9
{
    class Program
    {
        static void Main(string[] args)
        {

            int[,] A = new int[3, 3];
            Random ran = new Random();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    A[i, j] = ran.Next(1, 15);
                    Console.Write("{0}\t", A[i, j]);
                }
                Console.WriteLine();
                            }
            int sum = 0;
            int b = 0;
            for (int i = 0; i < 3; i++)
                    {
                        for (int j = 0; j < 3; j++)
                        {
                            if (((A[i, j] % 2) == 0)&&(i > j))
                    {
                        b = b + 1;
                        sum =sum+ A[i, j];
                        }
                }
            }
                                    
            Console.WriteLine("Среднее арифметическое чётных элементов, расположенных ниже главной диагонали:  "  + sum/b);
            Console.ReadKey();
           
      }
    }
}
