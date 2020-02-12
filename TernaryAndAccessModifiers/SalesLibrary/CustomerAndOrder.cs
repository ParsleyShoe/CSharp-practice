using System;
using System.Collections.Generic;
using System.Text;

namespace TernaryAndAccessModifiers {
    public class Customer {
        private static int NextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        private bool NationalAccount { get; set; }
        public void NationalAcc(string yesorno) {
            this.NationalAccount = yesorno.Equals("yes") ? true : false;
        }
        public override string ToString() {
            return $"ID is {this.Id}, Name is {this.Name}, Is it a national account? {NationalAccount}";
        }
        // instance methods can access static properties, however
        //     static methods can not access instance properties, methods, or initializers
        public void PrintNextId() {
            Console.WriteLine($"Next ID is {NextId}.");
        }
        static Customer() {
            // read file to get the next id to be assigned
            NextId = 21;
        }
        public Customer(string name) {
            Id = NextId++;
            Name = name;
        }


    }
    public class Order {
        private static int LastId = 7;
        static Order() {
            // read file to get the next id to be assigned
            LastId = 0;
        }
        public int Id { get; set; }
        public double Amount { get; set; }
        public Customer Customer { get; set; }
        public void SetCustomer(Customer customer) {

        }
        public Order(int id, double amount, Customer custid) {
            Id = LastId += 7;
            Amount = amount;
            Customer = custid;
        }
    }
}
