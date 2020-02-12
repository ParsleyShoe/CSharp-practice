using System;
using System.Collections.Generic;
using System.Text;

namespace NullableTypes {
    class Major {
        public int ID;
        public string Description;
        public int MinSATscore;
        public Major(int id, string desc, int minsat) {
            ID = id;
            Description = desc;
            MinSATscore = minsat;
        }
    }
}