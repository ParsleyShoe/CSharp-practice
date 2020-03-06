using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class MajorClassRel {

        public int Id { get; set; }
        public int MajorId { get; set; }
        public int ClassId { get; set; }

        public virtual Class Class { get; set; }
        public virtual Major Major { get; set; }

    }
}
