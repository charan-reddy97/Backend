using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.SMS
{
    public class AirtelSmsService:ISmsService
    {
        public string Sent(string message, string mobilenumber)
        {
            return $"Sending Sms : {message} -> {mobilenumber}, Provider : JIO";
        }

    }
}
