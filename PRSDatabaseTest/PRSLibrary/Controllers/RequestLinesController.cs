using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PRSLibrary.Models;

namespace PRSLibrary.Controllers {
    public class RequestLinesController {
        private static readonly PRSDbContext context = new PRSDbContext();

        private static void RecalcTotal(int requestid) {
            AttemptToSave();
            var request = context.Requests.Find(requestid);
            request.Total = context.RequestLines.Where(x => requestid == x.RequestId)
                                                .Sum(x => x.Product.Price * x.Quantity);
            AttemptToSave();
        }

        private static void AttemptToSave() {
            try {
                context.SaveChanges();
            } catch (Exception) {
                throw;
            }
        }

        public static IEnumerable<RequestLine> GetAll() {
            return context.RequestLines.ToList();
        }
        public static RequestLine GetByPK(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            return context.RequestLines.Find(id);
        }
        public static RequestLine Insert(RequestLine requestline) {
            if (requestline == null) throw new Exception("RequestLine cannot be null.");
            // edit checking goes here
            context.RequestLines.Add(requestline);
            RecalcTotal(requestline.RequestId);
            return requestline;
        }
        public static bool Update(int id, RequestLine requestline) {
            if (requestline == null) throw new Exception("RequestLine cannot be null.");
            if (id != requestline.Id) throw new Exception("ID must match RequestLine's.");
            context.Entry(requestline).State = EntityState.Modified;
            requestline.Product = context.Products.Find(requestline.ProductId);
            RecalcTotal(requestline.RequestId);
            return true;
        }
        public static bool Delete(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            // edit checking goes here
            RecalcTotal(context.RequestLines.Find(id).RequestId);
            return Delete(context.RequestLines.Find(id));
        }
        public static bool Delete(RequestLine requestline) {
            // edit checking goes here
            context.RequestLines.Remove(requestline);
            RecalcTotal(requestline.RequestId);
            return true;

        }
    }
}
