using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace debug
{
    class Program
    {
        static void Main(string[] args)
        {
            Trace.Listeners.Add(new TextWriterTraceListener($" (logfile_).txt "));
            Trace.Listeners.Add(new EventLogTraceListener());
            Trace.AutoFlush = true;
            Console.WriteLine("enter the max iterations");
            int max = int.Parse(Console.ReadLine());
            
            try
            {
                Trace.WriteLine(max);
                Debug.WriteLine(max);
                for (int i = 0; i < max; i++)
                {
                    int x = new Random().Next(21, 334);
                    int y = new Random().Next(24, 456);
                    int sum = add(x, y);
                    Trace.WriteLine($"{x},{y}");
                    Debug.WriteLine($"{x},{y}");
                    Console.Write($"{x}+{y}={sum}\n");
                }
            }
            catch(Exception exp)
            {
                Trace.WriteLine(exp.ToString());
            }
        }
        public static int add(int x, int y)
        {
            return x + y;
        }
    }
}
