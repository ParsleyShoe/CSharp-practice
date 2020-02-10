using System;
using System.Collections.Generic;
using System.Text;

namespace GenericCollections {
    class Customer {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool Active { get; set; }
        public Customer() { }
        public Customer(int id, string name, bool active) {
            Id = id;
            Name = name;
            Active = active;
        }
    }
}
