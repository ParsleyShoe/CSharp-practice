using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PRSLibrary.Models;

namespace PRSLibrary.Controllers {
    public class ProductController {
        private static readonly PRSDbContext context = new PRSDbContext();

        private static void AttemptToSave() {
            try {
                context.SaveChanges();
            } catch (DbUpdateException ex) {
                throw new Exception("Part number must be unique.", ex);
            } catch (Exception) {
                throw;
            }
        }

        public static IEnumerable<Product> GetAll() {
            return context.Products.ToList();
        }
        public static Product GetByPK(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            return context.Products.Find(id);
        }
        public static Product Insert(Product product) {
            if (product == null) throw new Exception("Product cannot be null.");
            // edit checking goes here
            context.Products.Add(product);
            AttemptToSave();
            return product;
        }
        public static bool Update(int id, Product product) {
            if (product == null) throw new Exception("Product cannot be null.");
            if (id != product.Id) throw new Exception("ID must match Product's.");
            context.Entry(product).State = EntityState.Modified;
            AttemptToSave();
            return true;
        }
        public static bool Delete(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            // edit checking goes here
            return Delete(context.Products.Find(id));
        }
        public static bool Delete(Product product) {
            // edit checking goes here
            context.Products.Remove(product);
            AttemptToSave();
            return true;

        }
    }
}
