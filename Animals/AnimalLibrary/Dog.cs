using System;

namespace AnimalLibrary {
    public enum MuzzleType { Long, Short, Collapsed }
    public enum BarkPitch { High, Medium, Low }
    public class Dog {
        public bool LongTail { get; set; }
        public BarkPitch BarkPitch { get; set; }
        public MuzzleType Muzzle { get; set; }
        public bool ExtremeSenseOfSmell { get; set; } = false;
        public string Name { get; set; }
        public string ToConsole () {
            return "Dog";
        }
        public Dog(string name) {
            Name = name;
        }
        public Dog() {}
    }
}
