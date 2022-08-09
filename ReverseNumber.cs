using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Practice_Problems
{
    public class ReverseNumber
    {
        int num = 0, num2, num1;
        public void Reverse()
        {
            Console.WriteLine("Enter Number : ");
            num = (int)Convert.ToInt64(Console.ReadLine());
            while(num1 != 0)
            {
                num2 = num1 % 10;
                num = num * 10 + num2;
                num1 = num1 / 10;
            }
            Console.WriteLine("{0} is the reversed number ", num);
        }

    }
}
