using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinqBasics
{
    public class Customer
    {
        

        public Customer(int id, string name, int age)
        {
            Id = id;
            Name = name;
            Age = age;
        }

        public int Id { set; get; }
        public string Name { get; set; }
        public int Age { set; get; }
        public override string ToString()
        {
            
            return $"ID:{Id}\nName:{Name}\nAge:{Age}";
        }
    }
    public class Address
    {
        public int AddressId;
        public string Address1;
        public int Pincode;
        public int CustomerId;

        public Address(int addressId, string address1, int pincode, int customerId)
        {
            AddressId = addressId;
            Address1 = address1;
            Pincode = pincode;
            CustomerId = customerId;
        }
    }
}
