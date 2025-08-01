using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Class1_2
    {
        public static void Main(string[] args)
        {
            int n = 5;


            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }


            for (int i = n - 1; i >= 1; i--)
            {
                for (int j = 1; j <= i; j++)
                    Console.Write("*");
                Console.WriteLine();
            }
        }
    }
}
