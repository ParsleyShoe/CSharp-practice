using System;

namespace BankingLibrary {
    public class SavingsAccount : Account {
        public decimal InterestRate { get; private set; } = 0.0367m;
        public void CalculateInterest(int months) {
            var interest = Balance * (InterestRate / 12) * months;
            Deposit(interest);
        }
        public SavingsAccount(decimal interest) : this() {
            InterestRate = interest;
        }
        public SavingsAccount() : base() {
            Nickname = "Savings Account";
        }
    }
}
