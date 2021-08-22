using System;

namespace ackermansFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            int m;
            int n;
            while (true)
            {
                Console.WriteLine("Give inputs 'm' and 'n' for my Ackerman's Function.");
                Console.WriteLine("Enter any absolute integer value for 'm':");
                m = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter any absolute integer value for 'n':");
                n = Convert.ToInt32(Console.ReadLine());

                int ackermansAnswer = AckermanFunc(m, n);
                Console.WriteLine($"The result of the Ackerman's Function is: {ackermansAnswer}\n");
            }
        }

        public static int AckermanFunc(int m, int n)
        {
            if (m == 0)
            {
                return n + 1;
            }
            else if (m > 0 && n == 0)
            {
                return AckermanFunc(m - 1, 1);
            }
            else // m > 0 && n > 0
            {
                return AckermanFunc(m -1 , AckermanFunc(m, n - 1));
            }
        }

    }
}
