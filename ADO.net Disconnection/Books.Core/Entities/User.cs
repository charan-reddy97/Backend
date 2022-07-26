using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Books.Core.Entities
{
    public enum Role
    {
        Reader=0,
        Admin=1,
        SystemAdmin=2
    }

    public class User : Base
    {
        public string Name { get; set; }
        public string Email { get; set; }
        [JsonIgnore]
        public string Password { get; set; }

        public Role Role { get; set; }
    }

}
