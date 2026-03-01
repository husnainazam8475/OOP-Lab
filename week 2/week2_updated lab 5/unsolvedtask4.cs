using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class unsolvedtask4
    {
        
    class Student
        {
            public string Name;
            public int Marks1;
            public int Marks2;
            public int Marks3;

            public double Aggregate()
            {
                return (Marks1 + Marks2 + Marks3) / 3.0;
            }
        }

        class Program
        {
            static Student[] students = new Student[10];
            static int count = 0;

            static void AddStudent()
            {
                Student s = new Student();

                Console.Write("Enter Name: ");
                s.Name = Console.ReadLine();

                Console.Write("Enter Marks 1: ");
                s.Marks1 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Marks 2: ");
                s.Marks2 = Convert.ToInt32(Console.ReadLine());

                Console.Write("Enter Marks 3: ");
                s.Marks3 = Convert.ToInt32(Console.ReadLine());

                students[count] = s;
                count++;

                Console.WriteLine("Student Added Successfully!");
            }

            static void ShowStudents()
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine("\nName: " + students[i].Name);
                    Console.WriteLine("Aggregate: " + students[i].Aggregate());
                }
            }

            static void TopStudent()
            {
                if (count == 0)
                {
                    Console.WriteLine("No Students Available");
                    return;
                }

                Student top = students[0];

                for (int i = 1; i < count; i++)
                {
                    if (students[i].Aggregate() > top.Aggregate())
                    {
                        top = students[i];
                    }
                }

                Console.WriteLine("\nTop Student: " + top.Name);
                Console.WriteLine("Top Aggregate: " + top.Aggregate());
            }

            static void Main()
            {
                int choice;

                do
                {
                    Console.WriteLine("\n1. Add Student");
                    Console.WriteLine("2. Show Students");
                    Console.WriteLine("3. Top Student");
                    Console.WriteLine("4. Exit");

                    Console.Write("Enter Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                        AddStudent();
                    else if (choice == 2)
                        ShowStudents();
                    else if (choice == 3)
                        TopStudent();

                } while (choice != 4);
            }
        }
    }
}

