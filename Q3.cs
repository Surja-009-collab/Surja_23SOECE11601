using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Q3
    {
        static void Main(string[] args)
        {
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Elements in reverse order:");
            for (int i = n - 1; i >= 0; i--)
                Console.Write(arr[i] + " ");

        }
    }
}
