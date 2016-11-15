using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[] mas = new int[n];
            Random R = new Random();
            for (int i = 0; i < n; i++)
            {
                mas[i] = R.Next(-100, 100);
                Console.Write("{0}\t", mas[i]);
            }
            Console.WriteLine();
            int max = mas[0];
            int j = 0;
            for (int i = 0; i < n; i++)
                if (mas[i] > max && mas[i] < 0)
                {
                    max = mas[i];
                    j = i;
                   }
                int g = mas[j];
                mas[j] = mas[n-1];
                mas[n-1] = g;
            for (int i = 0; i < n; i++)
             Console.Write("{0}\t", mas[i);
             Console.ReadKey();
        }
    }
}
