using System;

namespace Summer_OOP
{
    public abstract class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber) : base(accountNumber){}

        public override bool AuthorizeLoan(int loanAmount)
              =>  Balance >= 2 * loanAmount / 3;

        
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
        
        public override bool Equals(Object other)
        {
            if (other is CheckingAccount savingsAccount)
            {
                var obj = (CheckingAccount) other;
                return (this.AccountNumber == obj.AccountNumber) ? true : false;
            }
            return false;
        }
    }
}