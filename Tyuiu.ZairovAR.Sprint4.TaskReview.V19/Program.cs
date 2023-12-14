using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tyuiu.ZairovAR.Sprint4.TaskReview.V19.Lib;
namespace Tyuiu.ZairovAR.Sprint4.TaskReview.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            int n = 4;
            int m = 2;
            int[,] matrix = new int[n, m];

            string str = "90817264";

            int index = 0;


            Console.WriteLine("\nМассив:");
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{str[index]} \t");
                    index++;
                }
                Console.WriteLine();
            }


            Console.Write("Количество нечетных чисел: " + ds.Calculate(n, m, str));
            Console.ReadLine();
        }
    }
}
