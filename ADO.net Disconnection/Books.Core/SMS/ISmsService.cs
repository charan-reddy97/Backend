using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.SMS
{
    public interface ISmsService
    {
        string Sent(string message, string mobile);
    }
}
