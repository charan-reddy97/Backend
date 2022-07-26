using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace colectionsgeniric
{
    public class movies :IEquatable<movies>,IComparable<movies>
    {
        public string moviename;
        public string director;

        public int CompareTo(movies other)
        {
            return this.moviename.CompareTo(other.moviename);
            //if (this.director > other.director)
            //{
            //    return 1;
            //}
        }

        public bool  Equals(movies other)
        {
            return this.director == other.director;
        }
        public override string ToString()
        {
            return $"{ director},{ moviename}";
        }

        
    }
}
