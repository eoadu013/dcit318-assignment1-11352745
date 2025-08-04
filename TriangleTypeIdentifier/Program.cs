using System;

class TriangleTypeIdentifier
{
    static void Main()
    {
        Console.WriteLine("--- Triangle Type Identifier ---");
        Console.WriteLine("Enter three sides of a triangle:");

        Console.Write("Side 1: ");
        if (!double.TryParse(Console.ReadLine(), out double side1) || side1 <= 0)
        {
            Console.WriteLine("Invalid input for Side 1. Must be a positive number.");
            return;
        }

        Console.Write("Side 2: ");
        if (!double.TryParse(Console.ReadLine(), out double side2) || side2 <= 0)
        {
            Console.WriteLine("Invalid input for Side 2. Must be a positive number.");
            return;
        }

        Console.Write("Side 3: ");
        if (!double.TryParse(Console.ReadLine(), out double side3) || side3 <= 0)
        {
            Console.WriteLine("Invalid input for Side 3. Must be a positive number.");
            return;
        }

        // Check triangle inequality theorem
        if (side1 + side2 <= side3 || side1 + side3 <= side2 || side2 + side3 <= side1)
        {
            Console.WriteLine("These sides do not form a valid triangle.");
            return;
        }

        if (side1 == side2 && side2 == side3)
            Console.WriteLine("Triangle Type: Equilateral");
        else if (side1 == side2 || side1 == side3 || side2 == side3)
            Console.WriteLine("Triangle Type: Isosceles");
        else
            Console.WriteLine("Triangle Type: Scalene");

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}