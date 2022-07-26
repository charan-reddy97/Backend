using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inheritanc
{
    public abstract class charan
    {
        public string name;
        public int age;
        public string sex;
        public void moviename()
        {
            Console.WriteLine("BB1");
        }

        //public virtual  void pg()
        //{
        //    Console.WriteLine("iam in");
        //}
        //public virtual void pg(string mouse)
        //{
        //    mouse = "iam overloading";
        //    Console.WriteLine(mouse);
        //}
    }
    public class dheeraj :charan
    {
        public string profession;
        //public override void pg()
        //{
        //   // base.pg();
        //    Console.WriteLine("iam not in");
        //}
        public  new void moviename()
        {
            Console.WriteLine("RRR");
        }

    }
    public class amrit:dheeraj
    {
        //public override void pg()
        //{
        //   // base.pg();
        //    Console.WriteLine("i am outside");
        //}
        public  new void moviename()
        {
            Console.WriteLine("KGF");
        }
    }
}
