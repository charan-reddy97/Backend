using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc
{
    public class Program
    {
        static void Main(string[] args)
        {
            // var ram = new charan();
            // ram.age = int.Parse(Console.ReadLine());
            //ram.name = (Console.ReadLine());
            // ram.sex = Console.ReadLine();
            var bheem = new dheeraj();
            bheem.age = 12;
            Console.WriteLine(bheem.age);
            bheem.name = "charan";
            Console.WriteLine(bheem.name);
            bheem.sex = "male";
            Console.WriteLine(bheem.sex);
            //bheem.pg("i am here");
            bheem.moviename();
            var scott = new amrit();
            scott.age = 14;
            Console.WriteLine(scott.age);
            scott.name = "dheeraj";
            Console.WriteLine(scott.name);
            scott.sex = "male";
            Console.WriteLine(scott.sex);
            // scott.profession = Console.ReadLine();
            // scott.pg("i am here");
            scott.moviename();

        }
    }
}
