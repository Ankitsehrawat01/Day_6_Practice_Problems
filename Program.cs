namespace Day_6_Practice_Problems
{
    public class Program
    {
        public static void Main()
        {
            string a;
            Console.Write("Enter Program Name : ");
            a = Convert.ToString(Console.ReadLine());
            switch(a)
            {
                case "FibonacciSeries":
                    FibonacciSeries fibonacci = new FibonacciSeries();
                    fibonacci.PrintFibonacci();
                    break;
                case "PerfectNumber":
                    PerfectNumber num = new PerfectNumber();
                    num.Perfect();
                    break;
                case "ReverseNumber":
                    ReverseNumber reverse = new ReverseNumber();
                    reverse.Reverse();
                    break;
                case "PrimeNumbers":
                    PrimeNumber prime = new PrimeNumber();
                    prime.Prime();
                    break;
                case "CoupanNumber":
                    CoupanNumber cn = new CoupanNumber();
                    cn.Coupan();
                    break;
            } 
            
        }
    }
}