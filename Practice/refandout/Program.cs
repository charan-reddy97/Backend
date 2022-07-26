using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace refandout
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 3;
            Console.WriteLine($"before calling {a}");
            modvariable(ref a);
            Console.WriteLine($"after calling {a}");

        }
        public static void modvariable(ref int a)
        {
             a = a * a;
        }
    }
}
