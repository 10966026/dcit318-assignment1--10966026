using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketPriceCalculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter their age
            Console.Write("Enter your age: ");
            string input = Console.ReadLine();

            // Try to parse the input to an integer
            if (int.TryParse(input, out int age))
            {
                // Initialize the ticket price
                int ticketPrice = 10;

                // Check if the user is a senior citizen or a child
                if (age >= 65 || age <= 12)
                {
                    ticketPrice = 7;
                }

                // Display the ticket price
                Console.WriteLine($"The ticket price is: GHC{ticketPrice}");
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid age.");
            }

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
