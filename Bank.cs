using System.Collections.Generic;
using System.Text;

namespace Summer_OOP
{
    public class Bank
    {
        private IDictionary<int, BankAccount> _accounts = new Dictionary<int, BankAccount>();
        private double _rate = 0.01;
        private int _nextacct = 1;
        
        public int CreateNewAccount(Status status) {
            var newAccountNumber = _nextacct++;
            BankAccount account = new BankAccount(newAccountNumber);
            account.Status = status;
            _accounts.Add(newAccountNumber, account);
            return newAccountNumber;
        }
        
        public void StatusManagement(int accountNumber, Status status) {
            BankAccount account = _accounts[accountNumber];
            account.Status = status;
        }
        public int GetAccountBalance(int accountNumber) => _accounts[accountNumber].Balance;
        
        public void DepositAmount(int accountNumber, int amount) {
            var bankAccount = _accounts[accountNumber];
            var balance = bankAccount.Balance;
            bankAccount.Balance = balance + amount;
        }
        
        public bool AuthorizeLoan(int accountNumber, int loanAmount) {
            var bankAccount = _accounts[accountNumber];
            var balance = bankAccount.Balance;
            return balance >= loanAmount / 2;
        }
        
        public override string ToString() 
        {
            var accountNumbers = _accounts.Keys;
            StringBuilder builder = new StringBuilder();
            builder.Append($"The bank has {_accounts.Count} accounts.").AppendLine();
            foreach(int accountNumber in accountNumbers)
                builder.Append(_accounts[accountNumber].ToString()).AppendLine();
            return builder.ToString(); 
        }

        public void CalculateInterest()
        {
            var accountNumbers = _accounts.Keys;
            foreach (int accountNumber in accountNumbers)
            {
                var bankAccount = _accounts[accountNumber];
                var balance = bankAccount.Balance;
                var newBalance = (int) (balance * (1 + _rate));
                bankAccount.Balance = newBalance;
            }
        }


    }
}