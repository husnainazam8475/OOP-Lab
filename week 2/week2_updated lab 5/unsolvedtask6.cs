using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class unsolvedtask6
    {
        
    class MUser
        {
            public string Username;
            public string Password;
            public string Role;

            public MUser(string username, string password, string role)
            {
                Username = username;
                Password = password;
                Role = role;
            }
        }

        class Program
        {
            static string fileName = "users.txt";
            static MUser[] users = new MUser[50];
            static int count = 0;

            static void LoadUsers()
            {
                if (!File.Exists(fileName))
                    return;

                string[] lines = File.ReadAllLines(fileName);
                foreach (string line in lines)
                {
                    string[] parts = line.Split(',');
                    if (parts.Length == 3)
                    {
                        users[count] = new MUser(parts[0], parts[1], parts[2]);
                        count++;
                    }
                }
            }

            static void SaveUser(MUser u)
            {
                using (StreamWriter sw = File.AppendText(fileName))
                {
                    sw.WriteLine(u.Username + "," + u.Password + "," + u.Role);
                }
            }

            static void SignUp()
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();
                Console.Write("Enter Role: ");
                string role = Console.ReadLine();

                MUser u = new MUser(username, password, role);
                users[count] = u;
                count++;
                SaveUser(u);
                Console.WriteLine("SignUp Successful!");
            }

            static void SignIn()
            {
                Console.Write("Enter Username: ");
                string username = Console.ReadLine();
                Console.Write("Enter Password: ");
                string password = Console.ReadLine();

                bool found = false;
                for (int i = 0; i < count; i++)
                {
                    if (users[i].Username == username && users[i].Password == password)
                    {
                        Console.WriteLine("Login Successful! Role: " + users[i].Role);
                        found = true;
                        break;
                    }
                }

                if (!found)
                    Console.WriteLine("Invalid Username or Password");
            }

            static void Main()
            {
                LoadUsers();
                int choice = 0;

                while (choice != 3)
                {
                    Console.WriteLine("\n1. SignUp");
                    Console.WriteLine("2. SignIn");
                    Console.WriteLine("3. Exit");
                    Console.Write("Enter Choice: ");
                    choice = Convert.ToInt32(Console.ReadLine());

                    if (choice == 1)
                        SignUp();
                    else if (choice == 2)
                        SignIn();
                    else if (choice == 3)
                        Console.WriteLine("Program Ended");
                    else
                        Console.WriteLine("Invalid Choice");
                }
            }
        }
    }
}

