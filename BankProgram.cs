using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Summer_OOP
{

    public static class BankProgram
    {

      
        public static void Main(String[] args)
        {

            //composition root
            int accountNumber = 1;
            IDictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            accounts.Add(1, new CheckingAccount(1));
            accounts.Add(2, new SavingsAccount(2));
            Bank bank = new Bank(accounts, accountNumber);
            ConsoleUserInterface program = new ConsoleUserInterface(bank);
            program.Run();

        }
    }
}