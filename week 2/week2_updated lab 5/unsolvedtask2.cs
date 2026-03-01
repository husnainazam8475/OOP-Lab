using System;
using System.Collections.Generic;
using System.Text;

namespace week2_updated_lab_5
{
    internal class unsolvedtask2
    {
        
    class calculator
        {
            public double num1;
            public double num2;
            public calculator(double n1, double n2)
            {
                num1 = n1;
                num2 = n2;
            }
            public double add()
            {
                return num1 + num2;
            }
            public double substract()
            {
                return num1 - num2;
            }
            public double multiply()
            {
                return num1 * num2;
            }
            public double divide()
            {
                if (num2 != 0)
                    return num1 / num2;
                else
                    return 0;
            }
        }
        class program
        {
            static void Main()
            {
                calculator c1 = new calculator(5, 5);
                Console.WriteLine("Addition:" + c1.add());
                Console.WriteLine("Subtraction:" + c1.substract());
                Console.WriteLine("Multiplication" + c1.multiply());
                Console.WriteLine("Division" + c1.divide());
            }
        }
    }
}

