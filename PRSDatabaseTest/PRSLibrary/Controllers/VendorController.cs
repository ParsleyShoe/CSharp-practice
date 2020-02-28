using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PRSLibrary.Models;

namespace PRSLibrary.Controllers {
    public class VendorController {
        private static PRSDbContext context = new PRSDbContext();

        private static void AttemptToSave() {
            try {
                context.SaveChanges();
            } catch (DbUpdateException ex) {
                throw new Exception("Code must be unique.", ex);
            } catch (Exception) {
                throw;
            }
        }

        public static IEnumerable<Vendor> GetAll() {
            return context.Vendors.ToList();
        }
        public static Vendor GetByPK(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            return context.Vendors.Find(id);
        }
        public static Vendor Insert(Vendor vendor) {
            if (vendor == null) throw new Exception("Vendor cannot be null.");
            // edit checking goes here
            context.Vendors.Add(vendor);
            AttemptToSave();
            return vendor;
        }
        public static bool Update(int id, Vendor vendor) {
            if (vendor == null) throw new Exception("Vendor cannot be null.");
            if (id != vendor.Id) throw new Exception("ID must match Vendor's.");
            context.Entry(vendor).State = EntityState.Modified;
            AttemptToSave();
            return true;
        }
        public static bool Delete(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            // edit checking goes here
            return Delete(context.Vendors.Find(id));
        }
        public static bool Delete(Vendor vendor) {
            // edit checking goes here
            context.Vendors.Remove(vendor);
            AttemptToSave();
            return true;

        }
    }
}
