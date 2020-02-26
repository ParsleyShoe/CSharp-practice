using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PRSLibrary.Models;

namespace PRSLibrary.Controllers {
    public class RequestController {
        private static PRSDbContext context = new PRSDbContext();

        public static bool ChangeStatus(int requestid, string change) {
            var request = context.Requests.Find(requestid);
            if (request == null) {
                return false;
            }
            request.Status = change;
            return true;
        }

        public static bool Approve(int requestid) {
            return ChangeStatus(requestid, "APPROVED");
        }
        public static bool Review(int requestid) {
            return ChangeStatus(requestid, "REVIEW");
        }
        public static bool Reject(int requestid) {
            return ChangeStatus(requestid, "REJECTED");
        }

        public static List<Request> GetReview(int userid) {
            return context.Requests.Where(x => x.Status == "REVIEW" && x.UserId == userid).ToList();
        }
    }
}
