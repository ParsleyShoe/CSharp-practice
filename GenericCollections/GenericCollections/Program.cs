using System;
using System.Collections.Generic;

namespace GenericCollections {
    class Program {
        static void Main(string[] args) {
            #region practice with lists
            var ints = new List<int>();
            ints.Add(1);
            ints.Add(2);
            ints.Add(3);
            Console.WriteLine(ints.Count);
            foreach(var integer in ints) {
                Console.WriteLine(integer);
            }

            var sterngs = new List<string>();
            sterngs.Add("Robbie");
            sterngs.Add("Armon");
            sterngs.Add("George");
            sterngs.Add("Parsley");
            sterngs.Add("Danae");
            sterngs.Add("Traci");
            sterngs.Add("Laura");
            sterngs.Add("Ian");
            sterngs.Add("Manish");
            sterngs.Add("Vaughn");
            sterngs.Add("Sarah");
            sterngs.Add("David");
            foreach (var stringy in sterngs) {
                Console.WriteLine(stringy);
            }
            
            var customers = new List<Customer>();
            var amazon = new Customer(1, "Amazon", true);
            var pg = new Customer(2, "P&G", true);
            var target = new Customer { Id = 3, Name = "Target", Active = true };
            var meijer = new Customer { Id = 4, Name = "Meijer", Active = true };
            var microsoft = new Customer(5, "Microsoft", false);
            //var CustArray = new Customer[] { amazon, pg, meijer, target, microsoft };
            //customers.Add(amazon);
            //customers.Add(pg);
            //customers.Add(meijer);
            //customers.Add(target);
            //customers.Add(microsoft);
            customers.AddRange(new Customer[] { amazon, pg, meijer, target, microsoft });
            foreach (var custy in customers) {
                if (!custy.Active) { continue; }
                Console.WriteLine($"{custy.Name}, Active? {custy.Active}");
            }
            #endregion

            #region practice with dictionaries
            var Custdarctd = new Dictionary<int, Customer>();
            Custdarctd.Add(target.Id, target);
            Custdarctd.Add(amazon.Id, amazon);
            Custdarctd.Add(meijer.Id, meijer);
            Custdarctd.Add(pg.Id, pg);
            Custdarctd.Add(microsoft.Id, microsoft);

            for (int i = 1; i <= Custdarctd.Count; i++) {
                Console.WriteLine(Custdarctd[i].Name);
            }
            foreach (var thing in Custdarctd.Keys) {
                Console.WriteLine(Custdarctd[thing].Name);
            }
            //Console.WriteLine(Custdarctd[3].Name);

            #endregion
        }
    }
}
