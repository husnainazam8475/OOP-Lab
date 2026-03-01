using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class unsolvedtask3
    {
        
    
    class ATM
        {
            double balance;
            string[] history = new string[10];
            int count = 0;


            public ATM(double initialBalance)
            {
                balance = initialBalance;
            }

            public void Deposit(double amount)
            {
                balance += amount;
                history[count] = "Deposited: " + amount;
                count++;
            }

            public void Withdraw(double amount)
            {
                if (amount <= balance)
                {
                    balance -= amount;
                    history[count] = "Withdrawn: " + amount;
                    count++;
                }
                else
                {
                    Console.WriteLine("Insufficient Balance");
                }
            }

            public void CheckBalance()
            {
                Console.WriteLine("Current Balance: " + balance);
            }

            public void ShowHistory()
            {
                Console.WriteLine("Transaction History:");
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(history[i]);
                }
            }
        }

        class Program
        {
            static void Main()
            {
                ATM atm = new ATM(1000);

                int choice;
                do
                {
                    Console.WriteLine("\n1. Deposit");
                    Console.WriteLine("2. Withdraw");
                    Console.WriteLine("3. Check Balance");
                    Console.WriteLine("4. Show History");
                    Console.WriteLine("5. Exit");
                    Console.Write("Enter choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                    {
                        Console.Write("Enter amount: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        atm.Deposit(amount);
                    }
                    else if (choice == 2)
                    {
                        Console.Write("Enter amount: ");
                        double amount = Convert.ToDouble(Console.ReadLine());
                        atm.Withdraw(amount);
                    }
                    else if (choice == 3)
                    {
                        atm.CheckBalance();
                    }
                    else if (choice == 4)
                    {
                        atm.ShowHistory();
                    }

                } while (choice != 5);
            }
        }
    }
}