using System;

namespace OOPHomeTask2_1
{
    class BankAccount
    {
        private long _accountNumber;
        private double _balance;
        private TypeBankAccount _typeBankAccount;

        public BankAccount(long accountNumber, double balance, TypeBankAccount typeBankAccount)
        {
            _accountNumber = accountNumber;
            _balance = balance;
            _typeBankAccount = typeBankAccount;
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
        public void SetAccountInformation(long accountNumber, double balance, TypeBankAccount typeBankAccount)
        {
            _accountNumber = accountNumber;
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
