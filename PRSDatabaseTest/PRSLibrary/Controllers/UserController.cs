using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRSLibrary.Models;

namespace PRSLibrary.Controllers {
    public class UserController {
        private static PRSDbContext context = new PRSDbContext();

        public static User Login(string username, string password) {
            var user = context.Users.Where(x => x.Username == username && x.Password == password).ToList()[0];
            return user ?? null;
        }
    }
}
