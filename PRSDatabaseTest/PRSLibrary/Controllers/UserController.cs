using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PRSLibrary.Models;

namespace PRSLibrary.Controllers {
    public class UserController {
        private static PRSDbContext context = new PRSDbContext();

        public static User Login(string username, string password) {
            var user = context.Users.Where(x => x.Username == username && x.Password == password).Single();
            return user ?? null;
        }

        private static void AttemptToSave() {
            try {
                context.SaveChanges();
            } catch (DbUpdateException ex) {
                throw new Exception("Username must be unique.", ex);
            } catch (Exception) {
                throw;
            }
        }

        public static IEnumerable<User> GetAll() {
            return context.Users.ToList();
        }
        public static User GetByPK(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            return context.Users.Find(id);
        }
        public static User Insert(User user) {
            if (user == null) throw new Exception("User cannot be null.");
            // edit checking goes here
            context.Users.Add(user);
            AttemptToSave();
            return user;
        }
        public static bool Update(int id, User user) {
            if (user == null) throw new Exception("User cannot be null.");
            if (id != user.Id) throw new Exception("ID must match User's.");
            context.Entry(user).State = EntityState.Modified;
            AttemptToSave();
            return true;
        }
        public static bool Delete(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            // edit checking goes here
            return Delete(context.Users.Find(id));
        }
        public static bool Delete(User user) {
            // edit checking goes here
            context.Users.Remove(user);
            AttemptToSave();
            return true;

        }
    }
}
