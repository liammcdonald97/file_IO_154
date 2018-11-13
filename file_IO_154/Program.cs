using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace file_IO_154
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number:");
            string userInput = Console.ReadLine();            
            using (StreamWriter f1 = new StreamWriter(@"C:\Users\liamm\Logs\log1.txt", true))
            {
                f1.WriteLine(userInput);
            }
            System.Console.WriteLine("You entered: " + userInput);
            Console.ReadLine();
        }
    }
}
