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
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("Welcome to Logical Programs");
                
                Console.WriteLine("1-FibonacciSeries");
                Console.WriteLine("2-PerfectNumber");
                Console.WriteLine("3-PrimeNumber");
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
                        default:
                            Console.WriteLine("Invalid Option");
                            break;
                    }
                }
            }
        }
    }
}
