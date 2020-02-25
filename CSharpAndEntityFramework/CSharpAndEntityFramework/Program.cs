using System;
using EFLibrary;
using EFLibrary.Models;
using System.Linq;
using System.Collections.Generic;

namespace CSharpEFConsole {
    class Program {
        static void Main(string[] args) {
            var context = new AppDbContext();

            foreach (var orderId in context.Orders.Select(x => x.Id).ToArray()) {
                RecalcOrderAmount(orderId, context);
            }
            //AddOrderLine(context);
            //GetOrderlines(context);
            //AddCustomer(context);
            //GetCustomerByPK(context);
            //UpdateCustomer(context);
            //DeleteCustomer(context);
            //AddFiveNewOrders(context);
            //UpdateCustomerSales(context);
            //GetAllCustomers(context);

            //Console.WriteLine($"The average price is {context.Products.Average(x => x.Price)}"); // average price of any single product
            //var top2 = context.Products.Where(x => x.Id > 7); // all products where Id is greater than seven
            //var activeCusts = context.Customers.Where(x => x.Active); // all active customers
        }

        //static void AddOrders(AppDbContext context) {

        //}

        //static void TallyOrderLines(AppDbContext context) {
        //    var order = context.Orders.SingleOrDefault(o => o.Description == "Blue eraser");
        //    var orderlines = context.OrderLines.ToList();
        //    decimal sum = 0;
        //    orderlines.ForEach(line => sum += (line.Product.Price * line.Quantity));
        //    order.Amount = sum;
        //}
        static void RecalcOrderAmount(int orderId, AppDbContext context) {
            var order = context.Orders.Find(orderId);
            var total = context.OrderLines.Sum(line => line.Product.Price * line.Quantity);
            order.Amount = total;
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Amount update failed.");
        }

        static void GetOrderlines(AppDbContext context) {
            var orderlines = context.OrderLines.ToList();
            orderlines.ForEach(line => Console.WriteLine($"{line.Quantity} | {line.Order.Description} | {line.Product.Name}\n"));
        }
        static void AddOrderLine (AppDbContext context) {
            var order = context.Orders.SingleOrDefault(o => o.Description == "Yellow eraser");
            var product = context.Products.SingleOrDefault(p => p.Code == "ECHO-DOT");
            var product2 = context.Products.SingleOrDefault(p => p.Code == "FIRE-STICK");
            var orderline = new OrderLine {
                Id = 0, ProductId = product.Id, OrderId = order.Id, Quantity = 3
            };
            var orderline2 = new OrderLine {
                Id = 0, ProductId = product2.Id, OrderId = order.Id, Quantity = 3
            };
            context.OrderLines.AddRange(orderline, orderline2);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1 && rowsAffected != 2) throw new Exception("Order line insert failed.");
        }

        static void DeleteCustomer(AppDbContext context) {
            var cust = context.Customers.Find(2);
            if (cust == null) throw new Exception("Customer not found.");
            context.Customers.Remove(cust);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Delete failed.");
        }
        static void UpdateCustomer(AppDbContext context) {
            var custPK = 3;
            var cust = context.Customers.Find(custPK);
            if (cust == null) throw new Exception("Customer not found.");
            cust.Name = "Amazon";
            var rowsAffected = context.SaveChanges();
            if (rowsAffected != 1) throw new Exception("Failed to update customer.");
            Console.WriteLine("Update successfull!");
        }
        static void GetCustomerByPK(AppDbContext context) {
            var custPK = 2;
            var cust = context.Customers.Find(custPK);
            if (cust == null) throw new Exception("Customer not found.");
            Console.WriteLine(cust);
        }
        static void GetAllCustomers(AppDbContext context) {
            var custs = context.Customers.ToList();
            foreach (var c in custs) {
                Console.WriteLine(c);
            }
        }
        static void AddCustomer(AppDbContext context) {
            var cust = new Customer {
                Id = 0,
                Name = "Amazon",
                Sales = 0,
                Active = true
            };
            context.Customers.Add(cust);
            var rowsAffected = context.SaveChanges();
            if (rowsAffected == 0) throw new Exception("Add failed!");
            return;
        }

        static void UpdateCustomerSales(AppDbContext context) {
            var CustOrderJoin = from c in context.Customers
                                join o in context.Orders
                                on c.Id equals o.CustomerId
                                where c.Id == 1
                                select new { Amount   = o.Amount,
                                             Customer = c.Name,
                                             Order    = o.Description
                                };
            context.Customers.Find(1).Sales = CustOrderJoin.Sum(c => c.Amount);
            context.SaveChanges();
        }
        static void AddFiveNewOrders(AppDbContext context) {
            var order1 = new Order {
                Description = "Blue eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            var order2 = new Order {
                Description = "Yellow eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            var order3 = new Order {
                Description = "Purple eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            var order4 = new Order {
                Description = "Green eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            var order5 = new Order {
                Description = "Orange eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            context.Orders.Add(order1);
            context.Orders.Add(order2);
            context.Orders.Add(order3);
            context.Orders.Add(order4);
            context.Orders.Add(order5);
            //context.Orders.AddRange(order1, order2, order3, order4, order5);  ---  also valid!
            var rowsAffected = context.SaveChanges();
            if (rowsAffected == 0) throw new Exception("Adding five orders failed!");
            return;
        }
    }
}
