using System;

namespace OOPHomeTask2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount();
            account.GetAccountInformation();

            var account2 = new BankAccount(123);
            account2.GetAccountInformation();

            var account3 = new BankAccount(TypeBankAccount.Contribution);
            account3.GetAccountInformation();

            var account4 = new BankAccount(321.12, TypeBankAccount.Deposit);
            account4.GetAccountInformation();

            Console.ReadLine();
        }
    }
}
