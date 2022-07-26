using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 1, 2, 3, 4, 5, 6 };
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("please enter the index\n");
            try
            {
                int index = int.Parse(Console.ReadLine());
                Console.WriteLine(array[index]);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }









        }
    }
}
