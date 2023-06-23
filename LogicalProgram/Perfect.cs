using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    internal class Perfect
    {
        public  void Numbers()
        {
            int n, i, sum;
            int min, max;
            Console.WriteLine("Finding the Perfect number with in the given range");
            Console.WriteLine("Input starting range");
            min = int.Parse(Console.ReadLine());
            Console.WriteLine("Input ending range");
            max = int.Parse(Console.ReadLine());
            for (n = min; n <= max; n++)
            {
                
                i = 1;
                sum = 0;
                while (i < n)
                {
                    if (n % i == 0)
                        sum = sum + i;
                    i++;

                }
                if (sum == n)
                    Console.WriteLine("The Perfect Number is- "+n);
            }
        }
    }
}
