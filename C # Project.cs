using System;

class Program
{
    static void Main()
    {
        // Welcome message
        Console.WriteLine("Welcome to Package Express. Please follow the instructions below.");

        // Prompt user to enter the package weight
        Console.WriteLine("Please enter the package weight:");
        double weight = Convert.ToDouble(Console.ReadLine());

        // Check if the package is too heavy
        if (weight > 50)
        {
            // Display error message and exit if the weight exceeds 50
            Console.WriteLine("Package too heavy to be shipped via Package Express. Have a good day.");
            return;
        }

        // Prompt user to enter the package width
        Console.WriteLine("Please enter the package width:");
        double width = Convert.ToDouble(Console.ReadLine());

        // Prompt user to enter the package height
        Console.WriteLine("Please enter the package height:");
        double height = Convert.ToDouble(Console.ReadLine());

        // Prompt user to enter the package length
        Console.WriteLine("Please enter the package length:");
        double length = Convert.ToDouble(Console.ReadLine());

        // Check if the package is too big
        if ((width + height + length) > 50)
        {
            // Display error message and exit if the total dimensions exceed 50
            Console.WriteLine("Package too big to be shipped via Package Express.");
            return;
        }

        // Calculate the quote (dimensions multiplied by weight and divided by 100)
        double quote = (width * height * length * weight) / 100;

        // Display the quote to the user as a dollar amount
        Console.WriteLine($"Your estimated total for shipping this package is: ${quote.ToString("F2")}");
        Console.WriteLine("Thank you!");
    }
}
