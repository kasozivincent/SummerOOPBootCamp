namespace Summer_OOP
{
    public enum Status
    {
        Foreign, Domestic
    }
    
    public class BankAccount 
    {
        private static double _rate = 0.01;
        public BankAccount(int accountNumber) => AccountNumber = accountNumber;
        public int AccountNumber { get;}
        public int Balance { get; set; }
        public Status Status { get; set; }

        public override string ToString() =>
            $"Account Number : {AccountNumber}   Balance : {Balance}  Status : {Status}";

        public void DepositAmount(int amount)
            =>   Balance += amount;

        public bool AuthorizeLoan(int loanAmount)
            => Balance >= loanAmount / 2;

        public void CalculateInterest()
        {
            Balance += (int) (Balance * _rate);
        }
    }
}