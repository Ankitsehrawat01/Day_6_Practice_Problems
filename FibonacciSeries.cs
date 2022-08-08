using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Practice_Problems
{
    internal class FibonacciSeries
    {
        int firstnumber = 0, secondnumber = 2;
        int result;
        public void PrintFibonacci()
        {
            Console.WriteLine("Enter a Number to find Fibonacci Series");
            int number = Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i <+ number; i++)
            {
                Console.Write(" {0} ", firstnumber);
                result = firstnumber + secondnumber;
                firstnumber = secondnumber;
                secondnumber = result;
            }

        }
    }
}
