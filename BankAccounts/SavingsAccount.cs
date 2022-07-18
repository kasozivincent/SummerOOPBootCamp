using System;

namespace Summer_OOP
{
    public class SavingsAccount : BankAccount
    {
        private static double _rate = 0.01;

        public SavingsAccount(int accountNumber) : base(accountNumber)
        { 
        }

        public override int CompareTo(BankAccount other)
        {
            var ourBalance = Balance;
            var theirBalance = other.Balance;
            if (ourBalance == theirBalance)
                return 0;
            else if (ourBalance > theirBalance)
                return 1;
            else
                return -1;
        }

        public override string ToString()
            =>  $"Savings Account: Account Number : {AccountNumber}   Balance : {Balance}  Status : {Status}";
        
        public override bool AuthorizeLoan(int loanAmount)
          =>  Balance >= 0.5 * loanAmount;

        public override void CalculateInterest()
            => Balance += (int) (Balance * _rate);

        public override bool Equals(Object other)
        {
            if (other is SavingsAccount savingsAccount)
            {
                var obj = (SavingsAccount) other;
                return (this.AccountNumber == obj.AccountNumber) ? true : false;
            }
            return false;
        }
    
    }
}