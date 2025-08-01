using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Surja_23SOECE11601
{
    internal class class_1
    {
        public static void Main(string[] args)
        {

            int a = 5;
            int b = 5;
            int res = a++ + b++ + ++b;
            Console.WriteLine(res);
        }
    }
}
