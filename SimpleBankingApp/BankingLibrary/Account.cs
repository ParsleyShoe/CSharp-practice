using System;

namespace BankingLibrary {
    public class Account {
        public decimal Balance;
        public string Number;
        public string Nickname;
        public void Deposit(decimal amount) {
            Balance += amount;
        }
        public void Withdraw(decimal amount) {
            Balance -= amount;
        }
        public void Transfer(decimal amount, Account to, Account from) {
            from.Withdraw(amount);
            to.Deposit(amount);
        }
        public decimal ViewBalance(Account account) {
            return Balance;
        }
    }
}
