namespace Summer_OOP
{
    public class SavingsAccount : BankAccount
    {
        private static double _rate = 0.01;

        public SavingsAccount(int accountNumber) : base(accountNumber)
        {
        }
        
        public override string ToString()
            =>  $"Savings Account: Account Number : {AccountNumber}   Balance : {Balance}  Status : {Status}";
        
        public override bool AuthorizeLoan(int loanAmount)
          =>  Balance >= 0.5 * loanAmount;

        public void CalculateInterest()
            => Balance += (int) (Balance * _rate);
    
    }
}