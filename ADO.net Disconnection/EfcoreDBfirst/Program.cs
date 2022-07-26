using EfcoreDBfirst.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EfcoreDBfirst
{
    class Program
    {
        static ECOM_TRAININGContext entities = new ECOM_TRAININGContext();
        static void Main(string[] args)
        {
           

            Console.WriteLine("1.Display Customer List\n2.Display Product List\n3.Display order list");
            Console.WriteLine("Choose your option");
            var userinput = int.Parse(Console.ReadLine());
            if (userinput == 1)
            {
                CustomerList();
            }
            else if (userinput == 2)
            {
                ProductList();
           }
            else if(userinput==3)
            {
                OrderList();
            }
            //else if (userinput == 3)
            //{
            //    Console.WriteLine("enter the CustomerId");
            //    var customerID = int.Parse(Console.ReadLine());
            //    if (entities.Orders.Any(d => d.CustomerId == customerID))
            //    {
                   
            //        var order = entities.Orders.Include(d=>d.Product).Where(d => d.CustomerId==customerID) ;
            //        var toatalamount = entities.Orders.Where(d => d.CustomerId == customerID).Sum(d => d.TotalPrice);
            //        foreach (var o in order)
            //        {    
            //            Console.WriteLine($"{o.Product.ProductName}\t{o.Quantity}");
            //        }
            //        Console.WriteLine(toatalamount);
            //    }
            //    else
            //        Console.WriteLine("No orders on this Customer ID");
            //}

           



        }
        public static void CustomerList()
        {
            foreach (var c in entities.Customers)
              Console.WriteLine($"{c.Name}\t{c.Id}\t{c.Email}");

        }
        public static void ProductList()
        {
            foreach (var p in entities.Products)
                Console.WriteLine($"{p.Id}\t{p.ProductName}\t{p.UnitPrice}\t{p.TotalAvailableQuantity}");
        }
        public static void OrderList()
        {
            Console.WriteLine("enter the CustomerId");
               var customerID = int.Parse(Console.ReadLine());
            if (entities.Orders.Any(d => d.CustomerId == customerID))
            {

                var order = entities.Orders.Include(d => d.Product).Where(d => d.CustomerId == customerID);
                var toatalamount = entities.Orders.Where(d => d.CustomerId == customerID).Sum(d => d.TotalPrice);
                foreach (var o in order)
                {
                    Console.WriteLine($"{o.Product.ProductName}\t{o.Quantity}");
                }
                Console.WriteLine(toatalamount);
            }
            else
                Console.WriteLine("No orders on this Customer ID");
        }

    }
    
}
