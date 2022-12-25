using System.Numerics;


namespace ConsoleApp1
{
    public class Function
    {
        public Function()
        { }

        public BigInteger Factorial(int n)
        {
            var factorial = new BigInteger(1);
            for (int i = 1; i <= n; i++)
                factorial *= i;

            return factorial;
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            var tmp = new Function();
            Console.WriteLine(tmp.Factorial(5));
        }
    }
}