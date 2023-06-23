// program-1

using System;

namespace LNTLTI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the value :");
            int num = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int temp = num;
            while(num > 0)
            {
                sum += (num % 10);
                num /= 10;
            }
            Console.WriteLine($"Sum of digits in {temp} is {sum}");
        }
    }
}

///////////////////////////////////////////////////////////////////

// program-2

using System;

namespace LNTLTI
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the number :");
            int num = Convert.ToInt32(Console.ReadLine());
            int rev = 0;
            int temp = num;
            while(num > 0)
            {
                rev = rev*10 + (num % 10);
                num /= 10;
            }
            Console.WriteLine($"Reverse of the number is {rev}");

        }
    }
}


///////////////////////////////////////////////////////////////////

// program-3

using System;


namespace LNTLTI
{
    class Program
    {
        private static bool IsPrime(int n)
        {
            if (n <= 1) { return false; }
            for(int i = 2; i < n; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if (IsPrime(num))
                Console.WriteLine("Prime");
            else
                Console.WriteLine("Not prime");
        }
    }
}


///////////////////////////////////////////////////////////////////

// program-4

using System;


namespace LNTLTI
{
    class Program
    {
        private static int Factorial(int n)
        {
            if (n <= 0)     return 0;
            int fact = 1;
            for(int i = 1; i <= n; i++)
            {
                fact *= i;
            }
            return fact;
        }

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Factorial(num));
        }
    }
}


///////////////////////////////////////////////////////////////////

// program-5

using System;


namespace LNTLTI
{
    class Program
    {
        private static void PrintPattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = 0; j < (n-i); j++)
                {
                    Console.Write(j+1+" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            PrintPattern(num);
        }
    }
}


///////////////////////////////////////////////////////////////////

// program-6

using System;


namespace LNTLTI
{
    class Program
    {
        private static void PrintPattern(int n)
        {
            for(int i = 0; i < n; i++)
            {
                for(int j = n-i; j > 0; j--)
                {
                    Console.Write(j+" ");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            PrintPattern(num);
        }
    }
}


///////////////////////////////////////////////////////////////////

// program-7

using System;


namespace LNTLTI
{
    class Program
    {
        private static int AbsDiff(int n)
        {
            int last = n % 10;
            while (n >= 10)
                n /= 10;
            int first = n;

            return Math.Abs(last-first) ;
        }

        static void Main(string[] args)
        {
            int num = Convert.ToInt32(Console.ReadLine());
            if(num <= 9)
                Console.WriteLine("Invalid Input");
            else
                Console.WriteLine(AbsDiff(num));
        }
    }
}


///////////////////////////////////////////////////////////////////
