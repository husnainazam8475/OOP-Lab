using System;
using System.Collections.Generic;
using System.Text;

namespace lab_4
{
    internal class solvedtask1
    {
        static int add(int n1, int n2)
        { return n1 + n2; 
        }
        static void Main(string[] args)
        {
            int num1;
            int num2;
            Console.Write("Enter first number: ");
            num1 = int.Parse (Console.ReadLine());
            Console.Write("Enter second number: ");
            num2 = int.Parse (Console.ReadLine());  
int result = add(num1, num2);
            Console.WriteLine("sum is ");
            Console.Write(result);
            Console.Read();
        }
    }
}
