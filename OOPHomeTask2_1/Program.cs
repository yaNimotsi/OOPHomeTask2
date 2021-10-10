using System;

namespace OOPHomeTask2_1
{
    class Program
    {
        static void Main()
        {
            var account = new BankAccount(1, 120.54, TypeBankAccount.Deposit);
            account.GetAccountInformation();

            Console.ReadLine();
        }
    }
}
