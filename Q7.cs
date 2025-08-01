using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Q7
    {
        static void Main(string[] args)
        {
            int[] arr = new int[10];
            List<int> even = new List<int>();
            List<int> odd = new List<int>();
            Console.WriteLine("Enter 10 integers:");
            for (int i = 0; i < 10; i++)
                arr[i] = Convert.ToInt32(Console.ReadLine());
            foreach (int val in arr)
            {
                if (val % 2 == 0)
                    even.Add(val);
                else
                    odd.Add(val);
            }
            Console.WriteLine("Even numbers: " + string.Join(" ", even));
            Console.WriteLine("Odd numbers: " + string.Join(" ", odd));
        }
    }
}



