using System;
using System.Collections.Generic;
using System.Text;

namespace Summer_OOP
{
    public class BankProgram
    {
        public static void Main(String[] args)
        {
            //composition root
            int accountNumber = 1;
            IDictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            Bank bank = new Bank(accounts, accountNumber);
            ConsoleUserInterface program = new ConsoleUserInterface(bank);
            program.Run();
        }
    }
}