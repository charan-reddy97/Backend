using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MysampleLibrary
{
    public class parcel
    {
        public static bool checkparcelnumber(string parcelnumber)
        {
            return parcelnumber.StartsWith(parcelnumber.Trim());
        }
        
    }
}
