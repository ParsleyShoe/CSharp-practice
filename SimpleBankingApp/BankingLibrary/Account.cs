using System;

namespace BankingLibrary {
    public abstract class Account {
        public static int NextNumber = 100;
        public const int NumberPlus = 7;
        public decimal Balance { get; set; }
        public int Number { get; private set; }
        public string Nickname { get; set; } = "Account";

        private bool CheckAmountGTZero(decimal amount) {
            return (amount <= 0) ? false : true;
        }
        public void Deposit(decimal amount) {
            if (amount < 0) {
                Console.WriteLine("You can't deposit a negative amount.");
            } else if (amount == 0) {
                Console.WriteLine("You can't deposit $0.00.");
            } else {
                Balance += amount;
                Console.WriteLine($"${amount} successfully deposited into {Nickname}. Your current balance is ${Balance}.\n");
            }
        }
        public bool Withdraw(decimal amount) {
            if (amount < 0) {
                Console.WriteLine("You can't withdraw a negative amount.");
                return false;
            } else if (amount == 0) {
                Console.WriteLine("You can't withdraw $0.00.");
                return false;
            } else if (amount > Balance) {
                Console.WriteLine($"You can't withdraw more than your current balance (${Balance}).");
                return false;
            } else {
                Balance -= amount;
                Console.WriteLine($"${amount} successfully withdrawn from {Nickname}. Your current balance is ${Balance}.\n");
                return true;
            }
        }
        public void TransferTo(Account to, decimal amount) {
            if (this.Withdraw(amount)) {
                to.Deposit(amount);
            }
        }
        public void ViewBalance() {
            Console.WriteLine($"Your current balance is ${Balance}.\n");
        }
        public void Display() {
            Console.WriteLine($"Account name: {Nickname}\nAccount number: {Number}\nCurrent balance: ${Balance}\n");
        }

        public Account() {
            Number = NextNumber;
            NextNumber += NumberPlus;
        }
    }
}
