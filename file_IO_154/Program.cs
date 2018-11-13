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
            using (StreamReader f2 = File.OpenText(@"C:\Users\liamm\Logs\log1.txt"))
            {
                string output1;
                while((output1 = f2.ReadLine()) != null)
                {
                    Console.WriteLine("You entered: {0} ", output1);
                }              
            }
            
            Console.ReadLine();
        }
    }
}
