using System;

namespace OOPHomeTask2_2
{
    class Program
    {
        static void Main()
        {
            var account = new BankAccount(250.40, TypeBankAccount.CreditAccount);
            account.GetAccountInformation();
            
            Console.ReadLine();
        }
    }
}
