using System;

namespace OOPHomeTask2_5
{
    class Program
    {
        static void Main(string[] args)
        {
            var account = new BankAccount(321.12, TypeBankAccount.Deposit);
            account.GetAccountInformation();

            account.IncreaseBalance(100);

            account.ReduceBalance(500);
            account.ReduceBalance(300);

            Console.ReadLine();
        }
    }
}