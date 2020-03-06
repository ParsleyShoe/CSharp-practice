using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class StudentClassRel {

        public int Id { get; set; }
        public int ClassId { get; set; }
        public int StudentId { get; set; }

        public virtual Student Student { get; set; }
        public virtual Class Class { get; set; }

    }
}
