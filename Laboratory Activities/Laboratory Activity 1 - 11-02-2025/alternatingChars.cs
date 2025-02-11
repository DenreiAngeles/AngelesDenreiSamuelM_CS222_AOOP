using System;

class alternatingChars {
    static void Main() {
        Console.Write("First character: ");
        char first = Console.ReadKey().KeyChar;
        Console.WriteLine();
        
        Console.Write("Second character: ");
        char second = Console.ReadKey().KeyChar;
        Console.WriteLine();

        Console.Write("Enter Size: ");
        if (!int.TryParse(Console.ReadLine(), out int size) || size <= 0) {
            Console.WriteLine("Invalid Input. Please enter a valid number.");
            return;
        }

        for (int i = 0; i < size; i++) {
            for(int hyp = 1; hyp <= i; hyp++) {
                Console.Write("-");
            }
            if (i % 2 == 0) {
                Console.Write(first);
            } else {
                Console.Write(second);
            }
            Console.WriteLine();
        }
    } 
}