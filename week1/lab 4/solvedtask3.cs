using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;

namespace lab_4
{
    internal class solvedtask3
    {
        static void Main(string[] args)
        {
            string path = @"C:\Mac\Home\Desktop\Uni\OOP Lab\week1\lab 4\textfile.txt.txt";
            StreamWriter filevariable = new StreamWriter(path, true);
            filevariable.WriteLine("hy");
            filevariable.Flush();
            filevariable.Close();
        }
    }
}
