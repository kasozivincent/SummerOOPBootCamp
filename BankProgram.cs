using System;
using System.Collections.Generic;
using System.Text;

namespace Summer_OOP
{
    public static class BankProgram
    {
        interface ITest
        {
            void Foo();
        }

  
        
        public static void Main(String[] args)
        {
            //composition root
            int accountNumber = 1;
            IDictionary<int, BankAccount> accounts = new Dictionary<int, BankAccount>();
            Bank bank = new Bank(accounts, accountNumber);
            ConsoleUserInterface program = new ConsoleUserInterface(bank);
            program.Run();

            IDictionary<int, string> boo = new Dictionary<int, string>();
            boo[1] = "Hello";
        }
    }
}