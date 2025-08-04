using System;

class GradeCalculator
{
    static void Main()
    {
        Console.WriteLine("--- Grade Calculator ---");
        Console.Write("Enter numerical grade (0-100): ");

        if (int.TryParse(Console.ReadLine(), out int grade))
        {
            if (grade >= 90 && grade <= 100)
                Console.WriteLine("Letter Grade: A");
            else if (grade >= 80)
                Console.WriteLine("Letter Grade: B");
            else if (grade >= 70)
                Console.WriteLine("Letter Grade: C");
            else if (grade >= 60)
                Console.WriteLine("Letter Grade: D");
            else if (grade >= 0)
                Console.WriteLine("Letter Grade: F");
            else
                Console.WriteLine("Grade cannot be negative.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a number between 0 and 100.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}