using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Books.Core
{
    public abstract class Base
    {
        public int Id { get; set; }
        [JsonIgnore]
        public DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public DateTime? LastModifiedDate { get; set; }
        [JsonIgnore]
        public DateTime? DeletedDate { get; set; }
    }



}

