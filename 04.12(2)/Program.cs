using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Составить программу для графического изображения делимости чисел от 1 до n */
namespace _04._12_2_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                int cnt = 1;
                for (double j = 1; j < i/2 + 1; j++)
                {
                    if (i % j == 0)
                    {
                        cnt++;
                    }
                }
                Console.Write(i);
                for (int k = 0; k < cnt; k++)
                {
                    
                    Console.Write($"+");
                }
                Console.WriteLine("\n");
            }
            Console.ReadLine();
        }
    }
}
