using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumearator 
{
    class Program
    {
        static void Main(string[] args)
        {
            var birth = new birthday();
            //var mov = new Holidays();
            foreach (var i in birth)
                Console.WriteLine(i);
        }
    }
}
