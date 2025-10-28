using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutput_in_C_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Be användaren skriva sitt namn
            Console.WriteLine("Please enter your name:");

            // 2. Läs in namnet från konsolen
            string userName = Console.ReadLine();

            // 3. Skriv ut en hälsning med användarens namn
            Console.WriteLine("Hello, " + userName + "! Nice to meet you!");
        }
    }
}
