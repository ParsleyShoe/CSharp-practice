using BankingLibrary;
using System;

namespace SimpleBankingApp {
    class Program {
        static void Main(string[] args) {
            var myAccount = new CheckingAccount() {
                Nickname = "My Big Account", 
                Balance = 600
            };
            var mySavings = new SavingsAccount(0.041m) {
                Nickname = "Savings, yeah",
                Balance = 2000
            };
            mySavings.CalculateInterest(1);
            var my2oAccount = new CheckingAccount() {
                Nickname = "Auxiliary Checking",
                Balance = 100
            };
            myAccount.Deposit(400);
            myAccount.Withdraw(20);
            my2oAccount.Deposit(15);

            mySavings.TransferTo(my2oAccount, 25);
            myAccount.TransferTo(mySavings, 80);
            my2oAccount.TransferTo(myAccount, 200);
                Console.WriteLine();
            myAccount.Display();
            my2oAccount.Display();
            mySavings.Display();
        }
    }
}
