using System;

class TicketPriceCalculator
{
    static void Main()
    {
        Console.WriteLine("--- Ticket Price Calculator ---");
        Console.Write("Enter your age: ");

        if (int.TryParse(Console.ReadLine(), out int age))
        {
            if (age <= 12 || age >= 65)
                Console.WriteLine("Ticket Price: GHC7 (Discounted)");
            else if (age > 12 && age < 65)
                Console.WriteLine("Ticket Price: GHC10");
            else
                Console.WriteLine("Invalid age entered.");
        }
        else
        {
            Console.WriteLine("Invalid input. Please enter a valid age.");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}