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



            //  Login successful!
            //Console.WriteLine(UserController.Login("JollyRoger", "%*(#UDORCK"));

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
        }
    }
}
