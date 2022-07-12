using System;
using System.Text;

namespace Summer_OOP
{
    public class UserInterface 
    {
        private bool _done = default;
        private Bank _bank = new Bank();
        public void Run()
        {
            while (!_done)
            {
                StringBuilder builder = new StringBuilder();
                builder.Append("Enter Command : ").AppendLine();
                builder.Append("0 : Quit").AppendLine();
                builder.Append("1 : New Account").AppendLine();
                builder.Append("2 : Select Account").AppendLine();
                builder.Append("3 : Deposit Money").AppendLine();
                builder.Append("4 : Apply for loan").AppendLine();
                builder.Append("5 : Show account details").AppendLine();
                builder.Append("6 : Calculate Interest").AppendLine();
                builder.Append("7 : Status Management").AppendLine();

                string menu = builder.ToString();
                Console.WriteLine(menu);

                int cmd = int.Parse(Console.ReadLine());
                ProcessCommand(cmd);
            }
        }
        
        private void ProcessCommand(int cmd)
        {
            if (cmd == 0) Quit();
            else if (cmd == 1) CreateNewAccount();
            else if (cmd == 2) DisplayAccountDetails();
            else if (cmd == 3) DepositAmount();
            else if (cmd == 4) AuthorizeLoan();
            else if (cmd == 5) DisplayAccountsDetails();
            else if (cmd == 6) CalculateInterest();
            else if (cmd == 7) StatusManagement();
            else
                Console.WriteLine("illegal command");
        }
        
        private void Quit()
        {
            _done = true;
            Console.WriteLine("Goodbye!");
        }

        private void CreateNewAccount()
        {
            Status status = RequestForeign();
            var newAccountNumber = _bank.CreateNewAccount(status);
            Console.WriteLine($"Your account number is {newAccountNumber}");
        }

        private void DisplayAccountDetails()
        {
            Console.WriteLine("Enter account number : ");
            var accountNumber = int.Parse(Console.ReadLine());
            var balance = _bank.GetAccountBalance(accountNumber);
            Console.WriteLine($"The balance of account {accountNumber} is  {balance}");           
        }

        private void DepositAmount()
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter deposit amount: ");
            int amount = int.Parse(Console.ReadLine());
            _bank.DepositAmount(accountNumber, amount);
            Console.WriteLine($"Your new account balance is {_bank.GetAccountBalance(accountNumber)}");

        }

        private void AuthorizeLoan()
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter loan amount: ");
            int loanAmount = int.Parse(Console.ReadLine());
            var decision = _bank.AuthorizeLoan(accountNumber, loanAmount);
            
            if (decision)
                Console.WriteLine("Your loan is approved");
            else
                Console.WriteLine("Your loan is denied");
        }
        private void DisplayAccountsDetails() => Console.WriteLine(_bank.ToString());
        private void CalculateInterest() => _bank.CalculateInterest();
        
        private void StatusManagement() 
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());
            _bank.StatusManagement(accountNumber, RequestForeign());
        }
        
        private Status RequestForeign()
        {
            StringBuilder builder = new StringBuilder();
            builder.Append("Enter 1 for Foreign").AppendLine();
            builder.Append("Enter 2 for Domestic").AppendLine();

            Console.WriteLine(builder.ToString());
            string choice = Console.ReadLine();

            if (choice == "1")
                return Status.Foreign;
            else if (choice == "2")
                return Status.Domestic;
            else
                throw new Exception("Invalid Choice");
        }
    }
}