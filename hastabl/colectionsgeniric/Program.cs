using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectionsgeniric
{
    class Program
    {
        static void Main(string[] args)
        {
            #region collections
            //List<int> marks = new List<int>();
            //marks.Add(1);
            //marks.Add(2);
            //marks.Add(3);
            ////foreach(var i in marks)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //List<string> cities = new List<string>();
            //cities.Add("chennai");
            //cities.Add("Benguluru");
            //cities.Add("Mumbai");
            ////foreach(var i in cities)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //List<movies> mov = new List<movies>();
            //mov.Add(new movies { moviename = "RRR", director = "SSR" });
            //mov.Add(new movies { moviename = "KGF", director = "PN" });
            ////foreach(var charan in mov)
            ////{
            ////    Console.WriteLine(charan);
            ////}
            //SortedSet<int> charan = new SortedSet<int>();
            //charan.Add(1);
            //charan.Add(4);
            //charan.Add(0);
            //charan.Add(3);
            ////foreach(var num in charan)
            ////{
            ////    Console.WriteLine(num);
            ////}
            //SortedSet<string> character = new SortedSet<string>();
            //character.Add("Ram");
            //character.Add("bheem");
            //character.Add("rocky");
            ////foreach(var i in character)
            ////{
            ////    Console.WriteLine(i);
            ////}
            //SortedDictionary<string, List<int>> statetemp = new SortedDictionary<string, List<int>>();
            //statetemp.Add("Andhra Pradesh", new List<int> { 10,20,30});
            //statetemp.Add("Andhrdesh      ", new List<int> { 10, 60, 300 });
            //statetemp.Add("Andhr          ", new List<int> { 110, 240, 310 });
            //foreach (var i in statetemp)
            //{
            //    Console.WriteLine(i.Key);

            //        Console.WriteLine(i.Value);
            //}
            #endregion
            SortedSet<movies> Movies = new SortedSet<movies>();
            movies m1 = new movies { director = "SSR", moviename = "RRR" };
            movies m2 = new movies { director = "PN", moviename = "KGF" };
            Movies.Add(m1);
            Movies.Add(m2);
            movies m3 = new movies { director = "SSR", moviename = "RRR" };
            //if (Movies.Contains(m3))
            //    Console.WriteLine("list contains the data");
            //else
            //    Console.WriteLine("list doesnot contains data");
            //foreach (var b in Movies)
            //    Console.WriteLine(b);
            //Stack<string> ram = new Stack<string>();
            //ram.Push("beem");
            //ram.Push("charan");
            //ram.Push("ram");
            //Console.WriteLine(ram.Pop());
            //Console.WriteLine(ram.Pop());
            //Console.WriteLine(ram.Pop());
            Queue<string> ram = new Queue<string>();
            ram.Enqueue("1");
            ram.Enqueue("2");
            ram.Enqueue("4");
            ram.Enqueue("4");
            Console.WriteLine(ram.Dequeue());
            Console.WriteLine(ram.Dequeue());
            Console.WriteLine(ram.Count());
        }
    }
}
