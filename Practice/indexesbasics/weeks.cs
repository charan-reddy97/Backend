using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace indexesbasics
{
    public class weeks
    {
        int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
        public int this[int i]
        {
            get
            {
                return arr[i];
            }
            set
            {
                arr[i] = value;
            }
        }
    }
}
