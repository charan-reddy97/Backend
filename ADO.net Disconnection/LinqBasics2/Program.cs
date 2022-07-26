using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqBasics2
{
    class Program
    {
        static void Main(string[] args)
        {
            Customer c1 = new Customer { CustomerId = 1001, Email = "sreehariis@gmail.com", Name = "Sree" };
            Customer c2 = new Customer { CustomerId = 1002, Email = "kate@gmail.com", Name = "Kate" };
            Customer c3 = new Customer { CustomerId = 1003, Email = "mark@gmail.com", Name = "Mark" };

            Product p1 = new Product { ProductId = 1, Name = "Coffee", UnitPrice = 100.5F };
            Product p2 = new Product { ProductId = 2, Name = "Tea", UnitPrice = 120 };
            Product p3 = new Product { ProductId = 3, Name = "Shampoo", UnitPrice = 200 };
            Product p4 = new Product { ProductId = 4, Name = "Brushes", UnitPrice = 100 };

            Order o1 = new Order { CustomerId = c1.CustomerId, ProductId = p1.ProductId, OrderDate = DateTime.Now, OrderId = 1, OrderStatus = OrderStatus.DELIVERED };
            Order o2 = new Order { CustomerId = c2.CustomerId, ProductId = p1.ProductId, OrderDate = DateTime.Now, OrderId = 2, OrderStatus = OrderStatus.ONPROGRESS };
            Order o3 = new Order { CustomerId = c3.CustomerId, ProductId = p2.ProductId, OrderDate = DateTime.Now, OrderId = 3, OrderStatus = OrderStatus.OURFORDELIEVERY };
            Order o4 = new Order { CustomerId = c1.CustomerId, ProductId = p3.ProductId, OrderDate = DateTime.Now, OrderId = 4, OrderStatus = OrderStatus.DELIVERED };
            Order o5 = new Order { CustomerId = c1.CustomerId, ProductId = p4.ProductId, OrderDate = DateTime.Now, OrderId = 5, OrderStatus = OrderStatus.DELIVERED };


            List<Customer> customers = new List<Customer>();
            customers.Add(c1);
            customers.Add(c2);
            customers.Add(c3);

            List<Product> products = new List<Product>();
            products.Add(p1);
            products.Add(p2);
            products.Add(p3);
            products.Add(p4);

            List<Order> orders = new List<Order>();
            orders.Add(o1);
            orders.Add(o2);
            orders.Add(o3);
            orders.Add(o4);
            orders.Add(o5);
            #region Linqbasics2
            //var task = from c in customers
            //           join o in orders on c.CustomerId equals o.CustomerId
            //           join p in products on o.ProductId equals p.ProductId
            //           select new { c.CustomerId, p.ProductId, p.Name, o.OrderStatus };
            //foreach(var t in task)
            //{
            //    Console.WriteLine(t);
            //}
            //var orderstatus = customers.Join(orders, orders => orders.CustomerId, customers => customers.CustomerId,
            //    (customers, orders) => new { orders.OrderId, customers.Name });
            //foreach(var order in orderstatus)
            //{
            // Console.WriteLine(order);
            // }

            //var firstdelivered = orders.First(d => d.OrderStatus == OrderStatus.DELIVERED);
            //Console.WriteLine($"First Delivered Order ID:{firstdelivered.OrderId}");
            //var firstdelivered1 = orders.LastOrDefault(d => d.OrderStatus == OrderStatus.DELIVERED);
            //if (firstdelivered1 == null)
            //    Console.WriteLine("There is no match for the given status");
            //else
            //{
            //    Console.WriteLine($"last Delivered Order ID:{firstdelivered1.OrderId}");
            //}
            //if (orders.Any(d => d.OrderStatus != OrderStatus.DELIVERED))
            //    Console.WriteLine("there are still some items to be delivered ");
            //else
            //    Console.WriteLine("all items are delivered");
            #endregion
            //if (orders.Where(d => d.CustomerId == 1001).All(d => d.OrderStatus == OrderStatus.DELIVERED))
            //    Console.WriteLine("All items are delivered");
            //else
            //    Console.WriteLine("some items need to be delivered");

            for (int i = 1004; i < 1100; i++)
            {
                customers.Add(new Customer { CustomerId = i, Name = "Customer" + i, Email = "customer@gmail.com" });
            }
            //var top20 = customers.Take(20);
            ////foreach (var j in top20)
            //// Console.WriteLine(j);
            //var skip = customers.SkipLast(10).TakeLast(10);
            //foreach (var j in skip)
            //    Console.WriteLine(j);
            //Console.WriteLine("Enter the page size");
            //int pagesize = int.Parse(Console.ReadLine());
            //Console.WriteLine("Enter the page number");
            //int pagenumber = int.Parse(Console.ReadLine());
            //var items = customers.Skip(pagenumber* pagesize).Take(pagesize);
            //foreach (var i in items)
            //    Console.WriteLine(i);
            var groupbyproduct = orders.GroupBy(d => d.ProductId);
            foreach (var group in groupbyproduct)
            {
                Console.WriteLine($"Product ID:{group.Key}\tTotal Orders:{group.Count()}");
                
                foreach (var item in group)
                    Console.WriteLine($"\tOrderId:{item.OrderId}\tOrderStatus :{item.OrderStatus}\tCustomerId:{item.CustomerId}");
                Console.WriteLine("------------------------------------");
            }
            Console.WriteLine("------------------------------------");
            var groupbycustomer = orders.GroupBy(d => d.CustomerId);
            foreach (var group in groupbycustomer)
            {
                Console.WriteLine($"Customer ID:{group.Key}\tTotal Orders:{group.Count()}");
               
                foreach (var item in group)
                    Console.WriteLine($"\tOrderId:{item.OrderId}\tOrderStatus :{item.OrderStatus}\tProductId:{item.ProductId}");
                Console.WriteLine("------------------------------------");
            }



        }
    }
}
