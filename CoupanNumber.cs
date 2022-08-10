using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_6_Practice_Problems
{
    public class CoupanNumber
    {
        public void Coupan()
        {
            Console.WriteLine("Enter the number of distinct coupan needed");
            int number = Convert.ToInt32(Console.ReadLine());

            int[] coupan = new int[number];
            Random random = new Random();
            int generated = 0;
            int i = 0;
            while (i < number)
            {
                int randomnumber = random.Next(number+1);
                generated++;
                Console.WriteLine("Random Number is : "+randomnumber);
                if(coupan.Contains(randomnumber))
                {
                    continue;
                }
                else
                {
                    coupan[i] = randomnumber;
                }
                i++;
            }
            foreach(int coupans in coupan)
            {
                Console.WriteLine(coupans + " ");
            }
            Console.WriteLine("Random Numbers Needed to generate " + number + " number of coupons are: " + generated);
        }
    }
}

