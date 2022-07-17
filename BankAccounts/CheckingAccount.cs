namespace Summer_OOP
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber) : base(accountNumber){}

        public override string ToString()
              => $"Checking Account: Account Number : {AccountNumber}   Balance : {Balance}  Status : {Status}";

        public override bool AuthorizeLoan(int loanAmount)
              =>  Balance >= 2 * loanAmount / 3;

        public override void CalculateInterest()
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
    }
}