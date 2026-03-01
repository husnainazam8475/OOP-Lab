using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class unsolvedtask1
    {
    class Transaction
        {
            public int TransactionId;
            public string ProductName;
            public double Amount;
            public DateTime Date;

            public Transaction(int id, string name, double amount, DateTime date)
            {
                TransactionId = id;
                ProductName = name;
                Amount = amount;
                Date = date;
            }

            public Transaction(Transaction t)
            {
                TransactionId = t.TransactionId;
                ProductName = t.ProductName;
                Amount = t.Amount;
                Date = t.Date;
            }

            public void Show()
            {
                Console.WriteLine("ID: " + TransactionId);
                Console.WriteLine("Product: " + ProductName);
                Console.WriteLine("Amount: " + Amount);
                Console.WriteLine("Date: " + Date);
                Console.WriteLine();
            }
        }

        class Program
        {
            static void Main()
            {
                Transaction t1 = new Transaction(1, "Laptop", 75000, DateTime.Now);
                Transaction t2 = new Transaction(t1);

                t2.ProductName = "Mobile";
                t2.Amount = 50000;

                Console.WriteLine("Original Transaction:");
                t1.Show();

                Console.WriteLine("Copied Transaction:");
                t2.Show();
            }
        }
    }
}

