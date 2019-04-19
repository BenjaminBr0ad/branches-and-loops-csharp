using System;

namespace branches_and_loops
{
    class Program
    {
        static void ExploringIf()
        {
            int a = 5;
            int b = 6;
            if (a + b > 10)
            {
                System.Console.WriteLine("The answer is greater than 10.");
            }
            else
            {
                System.Console.WriteLine("The answer is not greater than 10.");
            }
        }
        
        static void Loops()
        {
            int counter = 0;
            while (counter < 10)
            {
                System.Console.WriteLine(counter);
                counter++;
            }

            for (int i = 0; i < 10; i++)
            {
                System.Console.WriteLine($"The current value of i is: {i}.");
            }
        }

        static void FizzBuzz()
        {
            for (int i = 1; i <= 100; i++)
            {
                if(i % 15 == 0)
                {
                    System.Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    System.Console.WriteLine("Fizz");
                }
                else if (i % 3 == 0)
                {
                    System.Console.WriteLine("Buzz");
                }
                else
                {
                    System.Console.WriteLine(i);
                }
            }
        }

        static void Main(string[] args)
        {
            // ExploringIf();
            // Loops();
            FizzBuzz();
        }
    }
}
