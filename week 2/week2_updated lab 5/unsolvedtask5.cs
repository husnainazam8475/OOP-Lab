using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class unsolvedtask5
    {
        
    class Product
        {
            public int ID;
            public string Name;
            public double Price;
            public string Category;
            public string Brand;
            public string Country;
        }

        class Program
        {
            static Product[] products = new Product[10];
            static int count = 0;

            static void AddProduct()
            {
                Product p = new Product();

                Console.Write("Enter ID: ");
                p.ID = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Name: ");
                p.Name = Console.ReadLine();

                Console.Write("Enter Price: ");
                p.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Enter Category: ");
                p.Category = Console.ReadLine();

                Console.Write("Enter Brand: ");
                p.Brand = Console.ReadLine();

                Console.Write("Enter Country: ");
                p.Country = Console.ReadLine();

                products[count] = p;
                count++;

                Console.WriteLine("Product Added Successfully!");
            }

            static void ShowProducts()
            {
                if (count == 0)
                {
                    Console.WriteLine("No Products Available");
                    return;
                }

                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nID: " + products[i].ID);
                    Console.WriteLine("Name: " + products[i].Name);
                    Console.WriteLine("Price: " + products[i].Price);
                    Console.WriteLine("Category: " + products[i].Category);
                    Console.WriteLine("Brand: " + products[i].Brand);
                    Console.WriteLine("Country: " + products[i].Country);
                }
            }

            static void TotalStoreWorth()
            {
                double total = 0;

                for (int i = 0; i < count; i++)
                {
                    total += products[i].Price;
                }

                Console.WriteLine("Total Store Worth: " + total);
            }

            static void Main()
            {
                int choice;

                do
                {
                    Console.WriteLine("\n1. Add Product");
                    Console.WriteLine("2. Show Products");
                    Console.WriteLine("3. Total Store Worth");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                        AddProduct();
                    else if (choice == 2)
                        ShowProducts();
                    else if (choice == 3)
                        TotalStoreWorth();

                } while (choice != 4);
            }
        }
    }
}

