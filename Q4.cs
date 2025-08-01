using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Q4
    {
        static void Main(string[] args)
        {
            int[] arr1 = new int[5];
            int[] arr2 = new int[5];
            Console.WriteLine("Enter 5 elements:");
            for (int i = 0; i < 5; i++)
                arr1[i] = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < 5; i++)
                arr2[i] = arr1[i];
            Console.WriteLine("Copied elements:");
            foreach (int item in arr2)
                Console.Write(item + " ");

        }
    }
}
