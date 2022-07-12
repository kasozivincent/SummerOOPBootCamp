using System;
using System.Collections.Generic;
using System.Text;

namespace Summer_OOP
{
    public class BankProgram
    {
        private IDictionary<int, int> accounts = new Dictionary<int, int>();

        private double rate = 0.01;
        private int nextacct = 0;
        private int current = -1;
        private bool done = false;

        public static void Main(String[] args)
        {
            BankProgram program = new BankProgram();
            program.Run();
        }

        public void Run()
        {
            while (!done)
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
            else
                Console.WriteLine("illegal command");
        }

        private void Quit()
        {
            done = true;
            Console.WriteLine("Goodbye!");
        }

        private void CreateNewAccount()
        {
            current = nextacct++; // generate account number
            accounts.Add(current, 0);
            Console.WriteLine($"Your new account number is {current}");
        }

        private void DisplayAccountDetails()
        {
            Console.WriteLine("Enter account number : ");
            int accountNumber = int.Parse(Console.ReadLine());
            int balance = accounts[accountNumber];
            Console.WriteLine($"The balance of account {accountNumber} is  {balance}");
        }

        private void DepositAmount()
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter deposit amount: ");
            int amount = int.Parse(Console.ReadLine());

            int balance = accounts[accountNumber];
            accounts[accountNumber] = balance + amount;
        }

        private void AuthorizeLoan()
        {
            Console.WriteLine("Enter account number: ");
            int accountNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter loan amount: ");
            int loanAmount = int.Parse(Console.ReadLine());

            int balance = accounts[accountNumber];
            if (balance >= loanAmount / 2)
                Console.WriteLine("Your loan is approved");
            else
                Console.WriteLine("Your loan is denied");
        }

        private void DisplayAccountsDetails()
        {
            var accountNumbers = accounts.Keys;
            Console.WriteLine($"The bank has {accountNumbers.Count}  accounts.");
            foreach (int accountNumber in accountNumbers)
                Console.WriteLine($"Bank account {accountNumber} : balance =  {accounts[accountNumber]}");
        }

        private void CalculateInterest()
        {
            var accountNumbers = accounts.Keys;
            foreach (int accountNumber in accountNumbers)
            {
                int balance = accounts[accountNumber];
                int newbalance = (int) (balance * (1 + rate));
                accounts[accountNumber] = newbalance;
            }
        }
    }
}