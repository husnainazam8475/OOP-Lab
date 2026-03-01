using System;
using System.Collections.Generic;
using System.Text;

namespace lab_3
{
    internal class unsolvedtask1
    {
        static void Main(string[] args)
        {
            int age = int.Parse(Console.ReadLine());
            int machineprice = int.Parse(Console.ReadLine());
            int toyprice = int.Parse(Console.ReadLine());
            int evencount = age / 2;
            int oddcount = age - evencount;
            int money = 0;
            int increment = 10;
            for (int i = 1; i <= evencount; i++)
            {
                money = money + increment;
                increment = increment + 10;
            }
            money = money - evencount;
            int totaltoymoney = toyprice * oddcount;
            money = totaltoymoney + money;
            if (money >= machineprice)
            {
                Console.WriteLine("yes");
                Console.Write(money - machineprice);
            }
            else { 
            Console.WriteLine("No ");

                Console.Write(machineprice - money);
            }






        }
    }
}
