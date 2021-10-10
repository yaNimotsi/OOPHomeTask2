using System;

namespace OOPHomeTask2_4
{
    class BankAccount
    {
        public static long AccountNumber { get; private set; }

        public double Balance { get; set; }
        
        public TypeBankAccount TypeBankAccount { get; }

        public BankAccount()
        {
            GenerateAccountNumber();
        }
        public BankAccount(double balance) : this()
        {
            Balance = balance;
        }
        public BankAccount(TypeBankAccount typeBankAccount) : this()
        {
            TypeBankAccount = typeBankAccount;
        }
        public BankAccount( double balance, TypeBankAccount typeBankAccount) : this()
        {
            Balance = balance;
            TypeBankAccount = typeBankAccount;
        }

        private void GenerateAccountNumber()
        {
            AccountNumber++;
        }

        /// <summary>
        /// Read account data
        /// </summary>
        public void GetAccountInformation()
        {
            Console.WriteLine($"Account number is: {AccountNumber}");
            Console.WriteLine($"Account balance is: {Balance}");
            Console.WriteLine($"Account type is: {TypeBankAccount}");
        }
    }

    public enum TypeBankAccount
    {
        Deposit = 1,
        Contribution = 2,
        CreditAccount = 3
    }
}
