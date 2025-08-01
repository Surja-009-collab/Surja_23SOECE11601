using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Q2
    {
        static void Main(string[] args)
        {
            int[] arr = new int[5];
            Console.WriteLine("Enter 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(arr);
            Console.WriteLine("Sorted array in ascending order:");
            foreach (int item in arr)
            {
                Console.Write(item + " ");
            }


        }
    }
}
