using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Customer> customers = new List<Customer>();
            customers.Add(new Customer(5, "charan", 25));
            customers.Add(new Customer(6, "Amrit", 24));
            customers.Add(new Customer(7, "ADheeraj", 23));
            customers.Add(new Customer(8, "AVinod", 22));
            List<Address> address = new List<Address>();
            address.Add(new Address(1, "Chittoor", 517167, 5));
            address.Add(new Address(2, "Chandragiri", 517166, 6));
            address.Add(new Address(3, "Kadapa", 517165, 7));
            address.Add(new Address(4, "Tirupati", 517164, 8));
            #region LinQ Basics
            //var customerlist = from c in customers
            //                   where c.Age > 20
            //                   orderby c.Name
            //                   select c;
            //foreach (var customer in customerlist)
            //  Console.WriteLine(customer);
            //var customerlistbyage = from c in customers
            // where c.Age > 20
            // orderby c.Name
            // select new { c.Name, c.Id };
            //foreach (var customer in customerlistbyage)
            //    Console.WriteLine($"{customer.Name}\t{customer.Id}");
            #endregion
            #region Linq Joins
            //var Customeraddress = from c in customers
            //          join a in address on c.Id equals a.CustomerId
            //          select new { c.Name, a.Address1 };
            //foreach (var add in Customeraddress)
            //{
            //    Console.WriteLine($"{add.Name}\t{add.Address1}");
            //}
            #endregion
            #region aggregate functions
            //var customerage = customers.Where(d => d.Age > 18).OrderByDescending(d => d.Age).Select(d=>new { d.Id } ) ;
            //foreach(var cusage in customerage)
            //{
            //    Console.WriteLine(cusage.Id);
            //}
            //var avgage = customers.Where(d => d.Name.StartsWith("A")).Average(d=>d.Age);
            //Console.WriteLine(avgage);
            //var minage = customers.Where(d => d.Name.StartsWith("A")).Min(d => d.Age);
            //Console.WriteLine($"Min Age :{minage}");
            //var maxage = customers.Where(d => d.Name.StartsWith("A")).Max(d => d.Age);
            //Console.WriteLine($"Max Age :{maxage}");
            //var count = customers.Count(d => d.Name.StartsWith("A"));
            //Console.WriteLine(count);
            //var customercount = customers.Where(d => d.Age > 20).Count();
            //Console.WriteLine(customercount);
            // var sum = customers.Sum(d => d.Age);
            //Console.WriteLine(sum);
            //var pincodes = address.Select(d => d.Pincode).Distinct();
            //Console.WriteLine("Distinct Pincodes:"+string.Join("\n,",pincodes));
            #endregion



        }
    }
}
