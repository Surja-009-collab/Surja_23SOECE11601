using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Class3_1
    {
        static void Main(string[] args)
        {
            int[] a = { 5, 6, 1, 2, 8, 10, 4 };
            int max = a[0];
            int min = a[0];

            for(int j = 0; j < a.Length - 1; j++)
            {
                if (a[j] < a[j + 1])
                {
                    max = a[j+1];
                }
            }
            Console.WriteLine(max);

            foreach (int i in a) {
                if (i > max) {
                    max = i;

                }
                if (i < min) {
                    min = i;
                }   


            }
            Console.WriteLine("Max element from foreach loop  : " + max);
            Console.WriteLine("Min element from foreach loop  : " + min);
            

            Console.WriteLine("Max num is : " + a.Max());
            Console.WriteLine("Min num is : " + a.Min());
            Console.WriteLine("Sum of element is : " + a.Sum());
            Console.WriteLine("Average is : " + a.Average());
            Console.WriteLine("Total element of array is : " + a.Count());
            Console.WriteLine("Sorted array is : " + string.Join(" ", a));
            Console.WriteLine("Reverse Array is :" + string.Join(" " , a.Reverse()));
            //Console.WriteLine(String.Join(" ", a.OrderBy(x => x)));


          
            foreach(int i in a)
            {
                Console.Write(i + " ");
            }


            //Array.Sort(a);
            //Array.Reverse(a);


        }
    }
}
