using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebEducationService.Models {
    public class Major {

        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public Major() {}

    }
}
