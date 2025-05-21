using System;

class FinalTotal
{
    static void Main()
    {
        int total = 10;

        Console.Write("Enter an integer: ");
        int input = Convert.ToInt32(Console.ReadLine());

        if (input > 0)
        {
            if (input % 2 == 0)
            {
                Console.WriteLine("The number is even.");
                total += input * input;
            }
            else
            {
                Console.WriteLine("The number is odd.");
                total += input * input * input;
            }
            Console.WriteLine(total);
        }
        else if (input < 0)
        {
            Console.Write("Enter another integer: ");
            int exponent = Convert.ToInt32(Console.ReadLine());

            double powerResult = Math.Pow(input, exponent);
            total += (int)powerResult;
            Console.WriteLine(total);
        }
        else
        {
            Console.WriteLine("Nothing happened.");
        }
    }
}
