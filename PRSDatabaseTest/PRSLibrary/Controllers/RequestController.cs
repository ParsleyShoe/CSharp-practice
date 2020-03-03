using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.EntityFrameworkCore;
using PRSLibrary.Models;

namespace PRSLibrary.Controllers {
    public class RequestController {
        private static readonly PRSDbContext context = new PRSDbContext();

        private static bool ChangeStatus(Request request, string change) {
            if (request == null) {
                return false;
            }
            request.Status = change;
            return true;
        }

        public static bool Approve(Request request) {
            return ChangeStatus(request, "APPROVED");
        }
        public static bool Review(Request request) {
            if (request.Total <= 50) {
                return ChangeStatus(request, "APPROVED");
            } else {
                return ChangeStatus(request, "REVIEW");
            }
        }
        public static bool Reject(Request request) {
            return ChangeStatus(request, "REJECTED");
        }

        public static List<Request> GetReview(int userid) {
            return context.Requests.Where(x => x.Status == "REVIEW" && x.UserId != userid).ToList();
        }

        private static void AttemptToSave() {
            try {
                context.SaveChanges();
            } catch (Exception) {
                throw;
            }
        }

        public static IEnumerable<Request> GetAll() {
            return context.Requests.ToList();
        }
        public static Request GetByPK(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            return context.Requests.Find(id);
        }
        public static Request Insert(Request request) {
            if (request == null) throw new Exception("Request cannot be null.");
            // edit checking goes here
            context.Requests.Add(request);
            AttemptToSave();
            return request;
        }
        public static bool Update(int id, Request request) {
            if (request == null) throw new Exception("Request cannot be null.");
            if (id != request.Id) throw new Exception("ID must match Request's.");
            context.Entry(request).State = EntityState.Modified;
            AttemptToSave();
            return true;
        }
        public static bool Delete(int id) {
            if (id < 1) throw new Exception("ID must be greater than zero.");
            // edit checking goes here
            return Delete(context.Requests.Find(id));
        }
        public static bool Delete(Request request) {
            // edit checking goes here
            context.Requests.Remove(request);
            AttemptToSave();
            return true;

        }
    }
}
