using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Practice_Problems
{
    public class PerfectNumber
    {
        int num = 0;
        int sum = 0;
        public void Perfect()
        {
            Console.WriteLine("Enter number");
            num = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < num; i++)
            {
                //dividend/divisor=quotient
                if (num % i == 0)
                {
                    Console.WriteLine(i +" ");
                    sum += i;
                }
            }
            if (sum.Equals(num))
            {
                Console.WriteLine("{0} is perfect number", num);
            }
            else
            {
                Console.WriteLine("{0} is not a perfect number", num);
            }

        }

    }
}
