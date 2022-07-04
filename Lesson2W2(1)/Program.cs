using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Lesson2W2_1_
{
    partial class Program
    {
        public class Account
        {
            int _number;

            decimal _balance;

            TypeOfBankAccount _typeAccount;

            public int InfoNumber()
            {
                return _number;
            }

            public decimal InfoBalance()
            {
                return _balance;
            }

            public TypeOfBankAccount InfoTypeAccount()
            {
                return _typeAccount;
            }

            public void FillNumber(int number)
            {
                _number = number;
            }

            public void FillBalance(decimal balance)
            {
                _balance = balance;

            }

            public void FillTypeAccount(TypeOfBankAccount typeAccount)
            {
                _typeAccount = typeAccount;
            }

            public void FullInfo()
            {
                Console.WriteLine($"Тип счёта: {_typeAccount}, Номер счёта: {_number}, Баланс: {_balance}");
            }
            static void Main(string[] args)
            {
                Random random = new Random();

                Account account = new Account();

                account.FillTypeAccount(TypeOfBankAccount.DEBIT);

                account.FillNumber(random.Next(1, 99999999));

                account.FillBalance(100000);

                account.FullInfo();
            }
            public enum TypeOfBankAccount
            {
                DEBIT,
                CREDIT,
                DEPOSIT,
                BUDGET
            }






        }


    }
}