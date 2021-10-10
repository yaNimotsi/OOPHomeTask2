using System;

namespace OOPHomeTask2_2
{
    class BankAccount
    {
        private static long _accountNumber;
        private double _balance;
        private TypeBankAccount _typeBankAccount;

        public BankAccount( double balance, TypeBankAccount typeBankAccount)
        {
            GenerateAccountNumber();
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

        /// <summary>
        /// Set account information
        /// </summary>
        /// <param name="accountNumber"> Number of account</param>
        /// <param name="balance"> Balance of account</param>
        /// <param name="typeBankAccount"> Type of account</param>
        public void SetAccountInformation(double balance, TypeBankAccount typeBankAccount)
        {
            _balance = balance;
            _typeBankAccount = typeBankAccount;
        }
    }

    public enum TypeBankAccount
    {
        Deposit = 1,
        Contribution = 2,
        CreditAccount = 3
    }
}
