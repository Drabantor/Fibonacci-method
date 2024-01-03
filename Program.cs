using System.Numerics;

namespace Fibonacci
{
    class Program
    {
        static void Main()
        {
            bool isRunning = true;

            while (isRunning)
            {
                Console.WriteLine("\n\t GENERATE THE FIBONACCI SEQUENCE");
                Console.Write("\n\t[1]Enter program");
                Console.WriteLine("\n\t[2]Quit program");

                try
                {
                    int menuChoice = Convert.ToInt32(Console.ReadLine());

                    if (menuChoice != 1)
                    {
                        Console.WriteLine("\nYou can only choose either number 1 or 2.");
                    }

                    switch (menuChoice)
                    {
                        case 1:

                            Console.WriteLine("Enter a number to generate the Fibonacci sequence:");
                            BigInteger number = (BigInteger)Convert.ToInt64(Console.ReadLine());
                            memo = new BigInteger[(int)number];
                            Console.WriteLine("===================================================================================");

                            for (BigInteger i = 0; i < number; i++)
                            {
                                Console.WriteLine("{0})", i + 1);
                                Console.WriteLine("Fibonacci no: " + Fibonacci(i).ToString("N0"));
                                Console.WriteLine("-----------------------------------------------------------------------------------");
                            }
                            Console.ReadLine();

                            break;

                        case 2:
                            isRunning = false;
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("\n\tWrong input format. Returning to the menu.");
                    continue;
                }
            }
        }

        private static BigInteger[]? memo;

        private static BigInteger Fibonacci(BigInteger n)
        {
            if (memo[(int)n] != 0)
            {
                return memo[(int)n];
            }

            if (n <= 1)
            {
                memo[(int)n] = n;
            }
            else
            {
                memo[(int)n] = Fibonacci(n - 1) + Fibonacci(n - 2);
            }

            return memo[(int)n];
        }
    }
}