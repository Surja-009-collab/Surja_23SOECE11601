using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class loopcnpt
    {
        static void Main(string[] args)
        {
            int num = 321;
            String[] units = {"zero", "One", "Two", "Three" };
            int temp = num;
            int[] digit = new int[10];
            int count = 0;

            
            while (temp > 0)
            {
                digit[count] = temp % 10;
                temp = temp / 10;
                count=count +1;
            }
            //Console.WriteLine("The number is: " + digit[count]);
            // reverse using for loop
            //Console.WriteLine("The number is: "+reverse);
            for (int i = count - 1; i >= 0; i--)
            {
                Console.WriteLine("Number in Words : " + units[digit[i]]);
            }
        }
    }
}
