using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> charan = new Queue<int>();
            token c = new token();
            for (int i=1;i<4;i++)
            {
                Console.WriteLine("enter your name");
                 c.name= Console.ReadLine();
                Console.WriteLine("enter your mobile number");
                c.mobilenumber = double.Parse(Console.ReadLine());
                int Token = i;
                Console.WriteLine($"Token ID :{Token}");
                //Queue<int> charan = new Queue<int>();
                charan.Enqueue(Token);
                //Console.WriteLine(charan.Dequeue());
            }
            Console.WriteLine("call Token ID");
            int counter = int.Parse(Console.ReadLine());
            for(int i=0;i<charan.Count;i++)
            {
                if(counter==i)
                {
                    int currenttoken = charan.Dequeue();
                    Console.WriteLine($"Current token is {currenttoken}");
                }
                
            }
            
           






        }
    }
}
