using System.Numerics;

namespace ConsoleApp1
{
    class Program
    {
        static public BigInteger Factorial(int n)
        {
            var factorial = new BigInteger(1);
            for (int i = 1; i <= n; i++)
                factorial *= i;

            return factorial;
        }

        static void Main(string[] args)
        {
            Console.WriteLine(Factorial(5));
        }
    }
}
