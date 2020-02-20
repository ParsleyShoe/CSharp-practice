using System;
using System.Collections.Generic;
using System.Text;

namespace SQLLibrary {
    public class Major {
        public Major () { }
        public int Id { get; set; }
        public string Description { get; set; }
        public int MinSAT { get; set; }

        public override string ToString() {
            return $"Major ID: {Id}  --  Minimum SAT score: {MinSAT}\nDescription: {Description}\n";
        }
    }
}
