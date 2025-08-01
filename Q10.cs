using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Q10
    {
        static void Main(string[] args)
        {
            int[,] a = new int[3, 3];
            int[,] b = new int[3, 3];
            int[,] sum = new int[3, 3];
            Console.WriteLine("Enter elements for Matrix A (3x3):");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    a[i, j] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements for Matrix B (3x3):");
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 3; j++)
                    b[i, j] = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Sum of the two matrices:");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    sum[i, j] = a[i, j] + b[i, j];
                    Console.Write(sum[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
