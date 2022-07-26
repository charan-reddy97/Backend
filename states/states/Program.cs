using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace states
{
    class Program
    {
        static void Main(string[] args)
        {
           Avg();
        }
        public static void Avg()
        {
           string[] array = new string[2];
            array[0] = "Andhra";
            array[1] = "TamilNadu";
            Console.WriteLine("enter the index");
            int index = int.Parse(Console.ReadLine());
            int[] Andhra = new int[3];
            Andhra[0] = 20;
            Andhra[1] = 30;
            int[] TamilNadu = new int[2];
            TamilNadu[0] = 60;
            TamilNadu[1] = 80;
            int sum = 0;
            if (index==0)
            {
                for (int i = 0; i < Andhra.Length; i++)
                {
                    sum = sum + Andhra[i];
                      
                }
                float avg = sum / Andhra.Length;
                Console.WriteLine($"Average temperature of different cities in Andhra :{avg}");
            }
            if (index == 1)
            {
                for (int i = 0; i < TamilNadu.Length; i++)
                {
                    sum = sum + TamilNadu[i];

                }
                float avg = sum / TamilNadu.Length;
                Console.WriteLine($"Average temperature of different cities in TamilNadu :{avg}");
            }




           

        }
    }
}
