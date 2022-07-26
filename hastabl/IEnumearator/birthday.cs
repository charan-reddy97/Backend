using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IEnumearator
{
    public class birthday : IEnumerable<birthday>
    {
        //public int[] date = { 12, 11 };
        //public string[] month= { "Nov", "Dec" };
        //public string[] wish= { "Happy Birthday", "Happy Birthday" };
        public birthday()
        {  
             int[] date = { 12, 11 };
         string[] month = { "Nov", "Dec" };
         string[] wish = { "Happy Birthday", "Happy Birthday" };
    }
            //int[] Date = date;
            //string[] Month = month;
            //string[] Wish = wish;
           



        public IEnumerator<birthday> GetEnumerator()
        {
            yield return new birthday();

        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
