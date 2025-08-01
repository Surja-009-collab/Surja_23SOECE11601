using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Q6
    {
      static void Main(string[] args)
            {
                int[] arr = new int[5];
                Console.WriteLine("Enter 5 elements:");
                for (int i = 0; i < 5; i++)
                    arr[i] = Convert.ToInt32(Console.ReadLine());
                int max = arr[0];
                int min = arr[0];
             foreach (int value in arr)
             {
                 if (value > max)
                      max = value;
                 if (value < min)
                     min = value;
            }
           Console.WriteLine("Maximum: " + max);
          Console.WriteLine("Minimum: " + min);
      }
    }
}


