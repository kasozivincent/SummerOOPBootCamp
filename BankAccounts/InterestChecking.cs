using System.IO;

namespace Summer_OOP
{
    public class InterestCheckingAccount : CheckingAccount
    {
        private double _rate = 0.01;
        public InterestCheckingAccount(int accountNumber) : base(accountNumber){}

        public override string ToString()
            => $"Interest Checking Account: Account Number : {AccountNumber}   Balance : {Balance}  Status : {Status}";

        public override void CalculateInterest()
            => Balance += (int) (Balance * _rate);
    }
}