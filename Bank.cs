using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Summer_OOP
{
    public class Bank
    {
        private IDictionary<int, BankAccount> _accounts;
        private int _nextacct;
        public Bank(IDictionary<int, BankAccount> repository, int lastAccountNumber)
        {
            this._accounts = repository;
            this._nextacct = lastAccountNumber;
        }

        
        public int CreateNewAccount(int type, Status status) {
            var newAccountNumber = _nextacct++;
            BankAccount account;
            if (type == 1)
                account = new SavingsAccount(newAccountNumber);
            else if (type == 2)
                account = new RegularCheckingAccount(newAccountNumber);
            else if (type == 3)
                account = new InterestCheckingAccount(newAccountNumber);
            else
                throw new Exception("Invalid Account type");
            account.Status = status;
            _accounts.Add(newAccountNumber, account);
            return newAccountNumber;
        }
        
        public void StatusManagement(int accountNumber, Status status) {
            BankAccount account = _accounts[accountNumber];
            account.Status = status;
        }

        public int GetAccountBalance(int accountNumber)
        {
            BankAccount bankAccount = _accounts[accountNumber];
            return bankAccount.Balance;
        } 
        
        public void DepositAmount(int accountNumber, int amount) {
            BankAccount bankAccount = _accounts[accountNumber];
            bankAccount.DepositAmount(amount);
        }
        
        public bool AuthorizeLoan(int accountNumber, int loanAmount) {
            BankAccount bankAccount = _accounts[accountNumber];
            return bankAccount.AuthorizeLoan(loanAmount);
        }
        
        public override string ToString() 
        {
            StringBuilder builder = new StringBuilder();
            builder.Append($"The bank has {_accounts.Count} accounts.").AppendLine();
            foreach (BankAccount account in _accounts.Values)
                builder.Append(account.ToString()).AppendLine();
            return builder.ToString(); 
        }

        public void CalculateInterest()
        {
            foreach (var account in _accounts.Values)
                account.CalculateInterest();
        }
    }
}