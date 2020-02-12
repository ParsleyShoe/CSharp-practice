using System;
using System.Collections.Generic;
using System.Text;

namespace AnimalLibrary {
    public class Pug : Dog {
        public bool CurlyTail { get; set; } = true;
        public bool SmallDog { get; set; } = true;
        public Pug(string Name) : base(Name) {
            this.Muzzle = MuzzleType.Collapsed;
            this.LongTail = false;
        }
        public Pug() : this("Pugly") {

        }
    }
}
