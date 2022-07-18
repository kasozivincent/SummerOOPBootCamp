using System;

namespace Summer_OOP
{
    public enum Status
    {
        Foreign, Domestic
    }
    
    public abstract class BankAccount : IComparable<BankAccount>
    {
        public BankAccount(int accountNumber) => AccountNumber = accountNumber;
        public int AccountNumber { get;}
        public int Balance { get; set; }
        public Status Status { get; set; }
        public void DepositAmount(int amount) =>   Balance += amount;
        public abstract bool AuthorizeLoan(int loanAmount);
        public abstract void CalculateInterest();
        public abstract int CompareTo(BankAccount other);
    }
}