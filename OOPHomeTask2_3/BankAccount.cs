using System;

namespace OOPHomeTask2_3
{
    class BankAccount
    {
        private static long _accountNumber;
        private double _balance;
        private TypeBankAccount _typeBankAccount;

        public BankAccount()
        {
            GenerateAccountNumber();
        }
        public BankAccount(double balance) : this()
        {
            _balance = balance;
        }
        public BankAccount(TypeBankAccount typeBankAccount) : this()
        {
            GenerateAccountNumber();
            _typeBankAccount = typeBankAccount;
        }
        public BankAccount( double balance, TypeBankAccount typeBankAccount) : this()
        {
            _balance = balance;
            _typeBankAccount = typeBankAccount;
        }

        private void GenerateAccountNumber()
        {
            _accountNumber++;
        }

        /// <summary>
        /// Read account data
        /// </summary>
        public void GetAccountInformation()
        {
            Console.WriteLine($"Account number is: {_accountNumber}");
            Console.WriteLine($"Account balance is: {_balance}");
            Console.WriteLine($"Account type is: {_typeBankAccount}");
        }

    }

    public enum TypeBankAccount
    {
        Deposit = 1,
        Contribution = 2,
        CreditAccount = 3
    }
}
