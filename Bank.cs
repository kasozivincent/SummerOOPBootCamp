using System.Collections.Generic;
using System.Text;

namespace Summer_OOP
{
    public class Bank
    {
        private IDictionary<int, int> _accounts = new Dictionary<int, int>();
        private double _rate = 0.01;
        private int _nextacct = 0;
        
        public int CreateNewAccount() {
            var newAccountNumber = _nextacct++;
            _accounts.Add(newAccountNumber, 0);
            return newAccountNumber;
        }
        
        public int GetAccountBalance(int accountNumber) => _accounts[accountNumber];
        
        public void DepositAmount(int accountNumber, int amount) {
            var balance = _accounts[accountNumber];
            _accounts.Add(accountNumber, balance + amount);
        }
        
        public bool AuthorizeLoan(int accountNumber, int loanAmount) {
            var balance = _accounts[accountNumber];
            return balance >= loanAmount / 2;
        }
        
        public override string ToString() 
        {
            var accountNumbers = _accounts.Keys;
            StringBuilder builder = new StringBuilder();
            builder.Append($"The bank has {_accounts.Count} accounts.").AppendLine();
            foreach(int accountNumber in accountNumbers)
                builder.Append($"Account Number : {accountNumber}   Balance : {_accounts[accountNumber]}").AppendLine();
            return builder.ToString(); 
        }

        public void CalculateInterest()
        {
            var accountNumbers = _accounts.Keys;
            foreach (int accountNumber in accountNumbers)
            {
                var balance = _accounts[accountNumber];
                var newBalance = (int) (balance * (1 + _rate));
                _accounts[accountNumber] = newBalance;
            }
        }


    }
}