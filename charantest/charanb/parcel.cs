using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysampleLibrary
{
    public class parcel
    {
        static List<string> PN = new List<string>();
        public static bool checkparcelnumber(string parcelnumber)
        {
            return parcelnumber.StartsWith(parcelnumber);
        }
        public static int Tp()
        {
            return PN.Count;
        }
        public static int add(string parcelnumber)
        {
            PN.Add(parcelnumber);
            return PN.Count;
        }

    }
}

