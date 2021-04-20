using System;
using System.Collections.Generic;
using System.Text;

namespace Task03.ATMClasses
{
    public class Customer
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public long CardNumber { get; set; }
        private int PinCode { get; set; }
        private double Balance { get; set; }

        // Customer constructor
        public Customer(string firstName, string lastName, long cardNo, int pin, double balance)
        {
            FirstName = firstName;
            LastName = lastName;
            CardNumber = cardNo;
            PinCode = pin;
            Balance = balance;
        }

        // Method for accessing the customer PIN
        public int AccessPin()
        {
            return PinCode;
        }

        // Prints current balance of money on customer acc
        public void PrintBalance()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Current balance of money on your acc {string.Format("{0:C}", Balance)}");
            Console.ResetColor();
        }

        // Prints full name
        public string PrintFullName()
        {
            return $"{FirstName} {LastName}";
        }

        // Method for CashWithdrawal
        public void CashWithdrawal(double cashToWithdraw)
        {
            if (cashToWithdraw <= Balance)
            {
                Balance -= cashToWithdraw;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Withdrawal succeeded! Here are your {string.Format("{0:C}", cashToWithdraw)}");
                Console.WriteLine($"Current balance of money on your account: {string.Format("{0:C}", Balance)}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Sorry you dont have enough money! Current balance: {string.Format("{0:C}", Balance)}");
                Console.ResetColor();
            }
        }

        // Method for CashDeposition
        public void CashDepositon(double cashToDeposit)
        {
            if (cashToDeposit > 0)
            {
                Balance += cashToDeposit;

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"Deposition succeeded! You successfully deposited {string.Format("{0:C}", cashToDeposit)} on your account.");
                Console.WriteLine($"Current balance of money on your account: {string.Format("{0:C}", Balance)}");
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Deposition failed! You must enter money you want to deposit! You can't deposit {string.Format("{0:C}", cashToDeposit)} on you account.");
                Console.ResetColor();
            }
        }

    }
}
