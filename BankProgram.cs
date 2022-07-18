using System;
using System.Collections.Generic;
using System.Linq;

namespace Summer_OOP
{
    class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
    }
    
    public static class BankProgram
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