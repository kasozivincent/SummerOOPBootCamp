namespace Summer_OOP
{
    public class RegularCheckingAccount : CheckingAccount
    {
        public RegularCheckingAccount(int accountNumber) : base(accountNumber)
        {
        }

        public override void CalculateInterest()
        { }
        
        public override string ToString()
            =>  $"Regular Checking Account: Account Number : {AccountNumber}   Balance : {Balance}  Status : {Status}";
    }
}