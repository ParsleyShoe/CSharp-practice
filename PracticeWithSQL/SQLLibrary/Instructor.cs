﻿using System;
using System.Collections.Generic;
using System.Text;

namespace SQLLibrary {
    public class Instructor {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public int YearsExperience { get; set; }
        public bool IsTenured { get; set; }

        public override string ToString() {
            return $"Instructor name: {Firstname} {Lastname}  --  {YearsExperience} years of teaching experience\n";
        }
    }
}
