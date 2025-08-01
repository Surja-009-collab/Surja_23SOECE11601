using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class Array
    {
        static void Main(string[] args)
        {
            var arr1 = new[] { 1, 2, 3, 4, 5 };
            var arr2 = new[] { 6, 7, 8, 9, 0 };
            var arr = arr1.Concat(arr2).ToArray();

        Console.WriteLine("Array : " + string.Join(", ", arr));   

        }

    }
}
