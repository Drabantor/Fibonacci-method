using System.Numerics;

namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
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
        }

        private static BigInteger[] memo;

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