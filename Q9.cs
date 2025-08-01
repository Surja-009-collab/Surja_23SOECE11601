using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Q9
    {
        static void Main(string[] args)
        {
            int[] arr = new int[100];
            Console.Write("Enter number of elements: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter elements:");
            for (int i = 0; i < n; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter position to delete (1 to {0}): ", n);
            int x = Convert.ToInt32(Console.ReadLine());
            if (x < 1 || x > n)
            {
                Console.WriteLine("Invalid position!");
                return;
            }
            for (int i = x - 1; i < n - 1; i++)
                arr[i] = arr[i + 1];
            Console.WriteLine("Array after deletion:");
            for (int i = 0; i < n - 1; i++)
                Console.Write(arr[i] + " ");
        }
    }
}
