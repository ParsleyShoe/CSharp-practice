using System;
using EFLibrary;
using EFLibrary.Models;
using System.Linq;
using System.Collections.Generic;

namespace CSharpEFConsole {
    class Program {
        static void Main(string[] args) {
            var context = new AppDbContext();
            //AddCustomer(context);
            //GetCustomerByPK(context);
            //UpdateCustomer(context);
            //DeleteCustomer(context);
            //AddFiveNewOrders(context);
            //UpdateCustomerSales(context);
            GetAllCustomers(context);

            //var 
            Console.WriteLine($"The average price is {context.Products.Average(x => x.Price)}"); // average price of any single product
            var top2 = context.Products.Where(x => x.Id > 7); // all products where Id is greater than seven
            var activeCusts = context.Customers.Where(x => x.Active); // all active customers
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
                //Id = 1,
                Description = "Blue eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            var order2 = new Order {
                //Id = 2,
                Description = "Yellow eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            var order3 = new Order {
                //Id = 3,
                Description = "Purple eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            var order4 = new Order {
                //Id = 4,
                Description = "Green eraser",
                Amount = 0.99m,
                CustomerId = 1
            };
            var order5 = new Order {
                //Id = 5,
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
