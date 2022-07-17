namespace Summer_OOP
{
    public class CheckingAccount : BankAccount
    {
        public CheckingAccount(int accountNumber) : base(accountNumber){}

        public override string ToString()
              => $"Checking Account: Account Number : {AccountNumber}   Balance : {Balance}  Status : {Status}";

        public override bool AuthorizeLoan(int loanAmount)
              =>  Balance >= 2 * loanAmount / 3;

    }
}