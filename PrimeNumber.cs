using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Practice_Problems
{
    internal class PrimeNumber
    {
        int n;
        int a = 0;
        public void Prime()
        {
            Console.Write("Enter a Number : ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i=1; i <= n; i++)
            {
                if(n % i == 0)
                {
                    a++;
                }
            }
            if(a == 2)
            {
                Console.WriteLine("{0} is a prime number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a prime number", n);
            }
        }
    }
}
