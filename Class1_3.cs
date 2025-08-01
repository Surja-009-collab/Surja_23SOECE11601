using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Class1_3
    {
        public static void Main(string[] args)
        {
            for (int i = 1; i <= 9; i++)
            {
                int  k = i  <=5 ? i : 10 - i;
                for (int j = 1; j <= 5 - i; j++)
                
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
