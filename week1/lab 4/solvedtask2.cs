using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace lab_4
{
    internal class solvedtask2
    {
        static void Main(string[] args)
        {
            string path = @"C:\Mac\Home\Desktop\Uni\OOP Lab\week1\lab 4\textfile.txt.txt";
            if (File.Exists(path))
            {
                StreamReader fileVariable = new StreamReader(path);
                string record;
                while ((record = fileVariable.ReadLine()) != null)
                {
                    Console.WriteLine(record);
                }
                fileVariable.Close();
            }
            else
            {
                Console.WriteLine("Not exists");
            }
        }
    }
}
