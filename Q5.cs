using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Q5
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            int count = 0;
            Console.WriteLine("Enter 10 elements:");
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 10; i++)
            {
                for (int j = i + 1; j < 10; j++)
                {
                    if (arr[i] == arr[j])

                    {
                        count++;
                        break;
                    }
                }
            }
            Console.WriteLine("Total duplicate elements: " + count);
        }
    }
}

