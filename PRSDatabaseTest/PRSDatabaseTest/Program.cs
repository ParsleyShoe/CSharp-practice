using System;
using PRSLibrary;
using PRSLibrary.Models;
using PRSLibrary.Controllers;
using System.Linq;
using System.Collections.Generic;

namespace PRSDatabaseTest {
    class Program {
        static void Main(string[] args) {
            var context = new PRSDbContext();

            Console.WriteLine("Hello.");

            var update = new RequestLine() {
                Id = 7,
                RequestId = 1,
                ProductId = 7,
                Quantity = 5
            };

            RequestLinesController.Update(7, update);

            Console.WriteLine("Goodbye.");

            #region logins
            ////  Login successful!
            //Console.WriteLine(UserController.Login("JollyRoger", "%*(#UDORCK"));

            ////  Login successful!
            //Console.WriteLine(UserController.Login("BellyOop", "951620!@#$UEOA"));

            ////  Reviewer
            //Console.WriteLine(UserController.Login("ManMan01", "password1"));

            ////  Admin
            //Console.WriteLine(UserController.Login("CEO-guy-lol", "#TronLegacy2010"));
            #endregion


            #region added new Users
            //var user = new User() {
            //    Username = "JollyRoger",
            //    Password = "%*(#UDORCK",
            //    Firstname = "James",
            //    Lastname = "Marshall",
            //    Phone = "973-746-2518"
            //};
            //var user2 = new User() {
            //    Username = "BellyOop",
            //    Password = "951620!@#$UEOA",
            //    Firstname = "Kameron",
            //    Lastname = "Thames",
            //    Email = "kampthames@yahoo.com"
            //};
            //var useR = new User() {
            //    Username = "ManMan01",
            //    Password = "password1",
            //    Firstname = "Gregory",
            //    Lastname = "Douglas",
            //    Email = "gregd@hotmail.com",
            //    IsReviewer = true
            //};
            //var usAr = new User() {
            //    Username = "CEO-guy-lol",
            //    Password = "#TronLegacy2010",
            //    Firstname = "Bill",
            //    Lastname = "Sizemore",
            //    Email = "bill.sizemore@gmail.com",
            //    //IsReviewer = true,
            //    IsAdmin = true
            //};
            //context.Users.AddRange(user, user2, useR, usAr);
            //context.SaveChanges();
            #endregion
            #region added new Vendors
            //var vendor1 = new Vendor() {
            //    Id = 0,
            //    Code = "10",
            //    Name = "Amazon",
            //    Address = "410 Terry Ave N",
            //    City = "Seattle",
            //    State = "WA",
            //    ZIP = "98109",
            //    Phone = "206-266-1000"
            //};
            //var vendor2 = new Vendor() {
            //    Id = 0,
            //    Code = "20",
            //    Name ="Skyline Chili",
            //    Address = "4180 Thunderbird Ln",
            //    City = "Fairfield",
            //    State = "OH",
            //    ZIP = "45014",
            //    Phone = "513-874-1188"
            //};
            //context.AddRange(vendor1, vendor2);
            //context.SaveChanges();
            #endregion
            #region added new Products
            //var prod1 = new Product() {
            //    Id = 0,
            //    PartNbr = "100",
            //    Name = "3-way",
            //    Price = 5.99m,
            //    Unit = "each",
            //    VendorId = 2
            //};
            //var prod2 = new Product() {
            //    Id = 0,
            //    PartNbr = "200",
            //    Name = "4-way",
            //    Price = 6.99m,
            //    Unit = "each",
            //    VendorId = 2
            //};
            //var prod3 = new Product() {
            //    Id = 0,
            //    PartNbr = "300",
            //    Name = "5-way",
            //    Price = 7.99m,
            //    Unit = "each",
            //    VendorId = 2
            //};
            //var prod4 = new Product() {
            //    Id = 0,
            //    PartNbr = "400",
            //    Name = "basic tripod stand",
            //    Price = 19.99m,
            //    Unit = "each",
            //    VendorId = 1
            //};
            //var prod5 = new Product() {
            //    Id = 0,
            //    PartNbr = "500",
            //    Name = "Ring © doorbell",
            //    Price = 27.99m,
            //    Unit = "each",
            //    VendorId = 1
            //};
            //var prod6 = new Product() {
            //    Id = 0,
            //    PartNbr = "600",
            //    Name = "tortilla plush blanket",
            //    Price = 34.49m,
            //    Unit = "each",
            //    VendorId = 1
            //};
            //context.AddRange(prod1, prod2, prod3, prod4, prod5, prod6);
            //context.SaveChanges();
            #endregion
            #region added new Requests
            //var req1 = new Request() {
            //    Id = 0,
            //    Description = "Order 1",
            //    Justification = "want",
            //    UserId = 1
            //};
            //var req2 = new Request() {
            //    Id = 0,
            //    Description = "Order 2",
            //    Justification = "want",
            //    UserId = 2
            //};
            //context.Requests.AddRange(req1, req2);
            //context.SaveChanges();
            #endregion
            #region added new RequestLines
            //var ln1 = new RequestLine() {
            //    Id = 0,
            //    RequestId = 1,
            //    ProductId = 1,
            //    Quantity = 2
            //};
            //var ln2 = new RequestLine() {
            //    Id = 0,
            //    RequestId = 1,
            //    ProductId = 2,
            //    Quantity = 3
            //};
            //var ln3 = new RequestLine() {
            //    Id = 0,
            //    RequestId = 1,
            //    ProductId = 3,
            //    Quantity = 2
            //};
            //var ln4 = new RequestLine() {
            //    Id = 0,
            //    RequestId = 2,
            //    ProductId = 4,
            //};
            //var ln5 = new RequestLine() {
            //    Id = 0,
            //    RequestId = 2,
            //    ProductId = 5,
            //};
            //var ln6 = new RequestLine() {
            //    Id = 0,
            //    RequestId = 2,
            //    ProductId = 6,
            //};
            //context.RequestLines.AddRange(ln1, ln2, ln3, ln4, ln5, ln6);
            //context.SaveChanges();
            #endregion
        }
    }
}
