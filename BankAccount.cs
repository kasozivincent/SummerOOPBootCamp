namespace Summer_OOP
{
    public enum Status
    {
        Foreign, Domestic
    }
    
    public class BankAccount 
    {
        public BankAccount(int accountNumber) => AccountNumber = accountNumber;
        public int AccountNumber { get;}
        public int Balance { get; set; }
        public Status Status { get; set; }

        public override string ToString() =>
            $"Account Number : {AccountNumber}   Balance : {Balance}  Status : {Status}";
    }
}