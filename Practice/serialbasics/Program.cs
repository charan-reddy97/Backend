using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace serialbasics
{
  internal  class Program
    {
        static void Main(string[] args)
        {
            var charan = new employee();
            charan.email = "charandhoni97@gmail.com";
            charan.ID = 1001;
            charan.name = "charan";
            Console.Write(charan);
        }
    }
}
