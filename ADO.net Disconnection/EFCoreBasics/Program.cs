using EFCoreBasics.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;

namespace EFCoreBasics
{
    public class Program
    {
        static EcomDBContext dBContext = new EcomDBContext();
        static void Main(string[] args)
        {
            #region ORM
            //Customer customer = new Customer { Name = "Charan", Email = "charandhoni97@gmail.com", CreatedDate = DateTime.Now };
            //dBContext.Customers.Add(customer);
            //dBContext.SaveChanges();
            //Product product = new Product { Name = "Coffee", UnitPrice = 10, TotalAvailableQuantity = 10 };
            //dBContext.Products.Add(product);
            //dBContext.SaveChanges();
            //Customer customer = new Customer { Name = "Amrit", Email = "amrit@gmail.com", CreatedDate = DateTime.Now };
            //Product product = new Product { Name = "Tea", UnitPrice = 20, TotalAvailableQuantity = 15 };

            //Order order = new Order();
            //order.Customer = customer;
            //order.Product = product;
            //order.Quantity = 2;
            //order.TotalPrice = order.Quantity * product.UnitPrice;
            //order.DeliveryStatus = DeliveryStatus.Pending;
            //order.CreatedDate = DateTime.Now;

            //dBContext.Orders.Add(order);
            //dBContext.SaveChanges();
            //var customers = dBContext.Customers.ToList();
            //foreach (var c in customers)
            //    Console.WriteLine(c);
            // var customer = dBContext.Customers.First(d => d.Id ==3);
            //Console.WriteLine(customer);

            //customer.ShippingAddress = "Chittoor";
            //dBContext.Update(customer);
            //dBContext.SaveChanges();
            //Product product = new Product();
            //var product = dBContext.Products.First(d => d.Id == 2);
            //Order order = new Order();
            //order.Customer = customer;
            //order.Product = product;
            //order.Quantity = 2;
            //order.TotalPrice = order.Quantity * product.UnitPrice;
            //order.DeliveryStatus = DeliveryStatus.Pending;
            //order.CreatedDate = DateTime.Now;

            //dBContext.Orders.Add(order);
            //dBContext.SaveChanges();
            //var Totalamount = dBContext.Orders.Sum(d => d.TotalPrice);
            //Console.WriteLine(Totalamount);

            //var avg = dBContext.Orders.Average(d => d.Quantity);
            //Console.WriteLine($"Average :{ avg}");

            // var max = dBContext.Products.Max(d => d.UnitPrice);
            //Console.WriteLine($"MAX :{max}");

            // var count = dBContext.Orders.Count(d => d.DeliveryStatus == DeliveryStatus.Pending);
            //Console.WriteLine($"Count :{count}");

            //var distinct = dBContext.Products.Select(d => d.Id == 2).Distinct();
            //Console.WriteLine($"Distinct :"+string.Join(",",distinct));

            //var orders = dBContext.Orders.
            //    Include(d=>d.Product).
            //    Include(d=>d.Customer).
            //    Where(d => d.DeliveryStatus == DeliveryStatus.Pending);
            //foreach (var o in orders)
            //{
            //    Console.WriteLine($"Customer Id :{o.Id}\tCustomer Name :{o.Customer.Name}\tProduct Name:{o.Product.Name}");
            //}
            // var delete = dBContext.Orders.First(d => d.Id == 2);
            //var delete = dBContext.Orders.Where(d => d.Id == 3).Select(d=>d.Id);
            //dBContext.Orders.Remove(delete);
            //dBContext.SaveChanges();

            // dBContext.Database.ExecuteSqlRaw("update orders set deliverystatus=3 where customerid=3");
            //Customer customer = new Customer();
            //Console.WriteLine("enter yourname");
            //customer.Name = Console.ReadLine();
            //Console.WriteLine("enter your email");
            //customer.Email = Console.ReadLine();
            //if (dBContext.Customers.Any(d => d.Name != customer.Name))
            //{
            //    dBContext.Customers.Add(customer);
            //    dBContext.SaveChanges();
            //}
            #endregion
            var cust = dBContext.Orders;
            foreach (var o in cust)
            {
                Console.WriteLine(o);
            }
               







        }
    }
}
