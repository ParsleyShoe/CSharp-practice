using BankingLibrary;
using System;

namespace SimpleBankingApp {
    class Program {
        static void Main(string[] args) {
            var myAccount = new CheckingAccount() {
                Nickname = "My Big Account", 
                Number = "192837465",
                //Balance = 1000.00
            };
            myAccount.Deposit(400);
            myAccount.Withdraw(20);
            myAccount.ViewBalance();
        }
    }
}
