using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TriangleTypeIdentifier
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Prompt the user to enter the three sides of the triangle
            Console.Write("Enter the length of side 1: ");
            string input1 = Console.ReadLine();
            Console.Write("Enter the length of side 2: ");
            string input2 = Console.ReadLine();
            Console.Write("Enter the length of side 3: ");
            string input3 = Console.ReadLine();

            // Try to parse the inputs to integers
            if (int.TryParse(input1, out int side1) && int.TryParse(input2, out int side2) && int.TryParse(input3, out int side3))
            {
                // Check if the sides form a valid triangle
                if (IsValidTriangle(side1, side2, side3))
                {
                    // Determine the type of triangle
                    string triangleType = GetTriangleType(side1, side2, side3);

                    // Display the type of triangle
                    Console.WriteLine($"The triangle is: {triangleType}");
                }
                else
                {
                    Console.WriteLine("Error: The entered sides do not form a valid triangle.");
                }
            }
            else
            {
                Console.WriteLine("Error: Invalid input. Please enter valid numbers for the sides.");
            }

            // Keep the console window open
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }

        static bool IsValidTriangle(int side1, int side2, int side3)
        {
            // A triangle is valid if the sum of any two sides is greater than the third side
            return (side1 + side2 > side3) && (side1 + side3 > side2) && (side2 + side3 > side1);
        }

        static string GetTriangleType(int side1, int side2, int side3)
        {
            if (side1 == side2 && side2 == side3)
            {
                return "Equilateral";
            }
            else if (side1 == side2 || side1 == side3 || side2 == side3)
            {
                return "Isosceles";
            }
            else
            {
                return "Scalene";
            }
        }
    }
}
