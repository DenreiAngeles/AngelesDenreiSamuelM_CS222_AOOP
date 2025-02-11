using System;

class squarePattern {
    static void Main() {
        Console.Write("Enter n: ");
        if (!int.TryParse(Console.ReadLine(), out int num) || num <= 0) {
            Console.WriteLine("Invalid input. Please enter a valid input.");
            return;
        }

        Console.Write("Enter y: ");
        if (!int.TryParse(Console.ReadLine(), out int skip) || skip < 1 || skip > num) {
            Console.WriteLine("Invalid input. Please enter a valid number between 1 and " + num + ".");
            return;
        }

        for (int i = 1; i <= num; i++)
        {
            if (i == skip) {
                Console.WriteLine();
                continue;
            } 

            for (int j = 1; j <= num; j++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
        }
    }
}