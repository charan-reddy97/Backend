using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastabl
{
    class Program
    {
        static void Main(string[] args)
        {
            #region hastable cities
            //Hashtable charan = new Hashtable();
            //charan.Add("karnataka", "Benguluru");
            //charan.Add("Andhra", "Vizag");
            //var city = charan["Andhra"];
            //foreach(var key in charan.Keys)
            //{
            //    Console.WriteLine($"{key} {charan[key]}");
            //}
            #endregion
            #region task
            Hashtable student = new Hashtable();
           // int[] register = new int[2];
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine("enter the register number");
                //int register = int.Parse(Console.ReadLine());
                Console.Write("enter the subject 1 marks");
                int m1 = int.Parse(Console.ReadLine());
                Console.Write("enter the subject 2 marks");
                int m2 = int.Parse(Console.ReadLine());
                Console.Write("enter the subject 3 marks");
                int m3 = int.Parse(Console.ReadLine());
                Console.Write("enter the subject 4 marks");
                int m4 = int.Parse(Console.ReadLine());
                Console.Write("enter the subject 5 marks");
                int m5 = int.Parse(Console.ReadLine());
                //student.Add(register,new int[] {m1,m2,m3,m4,m5  });
  
            }
            int sum = 0;
            string register = "";
            foreach(var charan in student)
            {

            }

            #endregion
        }
    }
}
