using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task9_2
{
    public class BankAccount
    {
        private static int _totalAccounts = 0;
        private static readonly Random _rndacc = new Random();
        public int AccountNumber { get; }
        public decimal Balance { get; private set; }

        public BankAccount()
        {
            _totalAccounts++;
            AccountNumber = _rndacc.Next(0, 10000);
            Balance = 0;
        }

        public void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public void Withdraw(decimal amount)
        {
            if (amount <= 0)
                throw new ArgumentException("Сумма должна быть положительной");

            if (amount > Balance)
                throw new InvalidOperationException("Недостаточно средств на счете");
            Balance -= amount;
        }

        public static void ShowTotalAccounts()
        {
            Console.WriteLine("Всего счетов в банке {0}", _totalAccounts);
        }
        public override string ToString()
        {
            return string.Format("Счет: {0}, Баланс {1} руб.", AccountNumber, Balance);
        }
    }


    internal class Program
    {
        static void Main(string[] args)
        {
            BankAccount account1 = new BankAccount();
            Console.WriteLine(account1.ToString());
            account1.Deposit(100);
            Console.WriteLine($"Баланс после пополнения: {account1.Balance} руб.");
            account1.Withdraw(50);
            Console.WriteLine($"Баланс после снятия: {account1.Balance} руб.");

            BankAccount account2 = new BankAccount();
            Console.WriteLine(account2.ToString());
            account2.Deposit(250);
            Console.WriteLine($"Баланс после пополнения: {account2.Balance} руб.");
            account2.Withdraw(30);
            Console.WriteLine($"Balance after withdraw: {account2.Balance} руб.");

            BankAccount.ShowTotalAccounts();
        }
    }
}
