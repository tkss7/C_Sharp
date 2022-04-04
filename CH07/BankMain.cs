//BankMain.cs
using System;
using Bank;

namespace BankMain
{
    class BankMain
    {
        static void Main(string[] args)
        {
            BankAccount a1 = new BankAccount();

            a1.SetName("kim");
            Console.WriteLine("{0}, {1} ", a1.GetName(), a1.GetBalance());

            a1.Deposit(10000);
            Console.WriteLine("{0}, {1} ", a1.GetName(), a1.GetBalance());

            a1.Withdraw(4000);
            Console.WriteLine("{0}, {1} ", a1.GetName(), a1.GetBalance());

            a1.Withdraw(10000);
            Console.WriteLine("{0}, {1} ", a1.GetName(), a1.GetBalance());

        }
    }
}
