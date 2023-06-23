using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Logical Programs");

            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n");
                Console.WriteLine("1-FibonacciSeries");
                Console.WriteLine("2-PerfectNumber");
                Console.WriteLine("3-PrimeNumber");
                Console.WriteLine("4-ReverseNumber");
                Console.WriteLine("5-CouponCode");
                {
                    Console.WriteLine("CHOOSE THE ABOVE OPTIONS");

                    int option = Convert.ToInt32(Console.ReadLine());
                    switch (option)
                    {
                        case 1:
                            Console.WriteLine("Fibonacci Series Program");
                            Fibonacci fibonacci = new Fibonacci();
                            fibonacci.Series();
                            break;
                        case 2:
                            Console.WriteLine("Perfect Number program");
                            Perfect perfect = new Perfect();
                            perfect.Numbers();
                            break;
                        case 3:
                            Console.WriteLine("Prime Number Program");
                            Prime prime = new Prime();
                            prime.Number();
                            break;
                        case 4:
                            Console.WriteLine("Reverse of number");
                            Reverse reverse = new Reverse();
                            reverse.Display();
                            break;
                        case 5:
                            Console.WriteLine("Generating Coupon code");
                            Coupon coupon = new Coupon();
                            coupon.Number();
                            break;  
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
            }
        }
    }
}
