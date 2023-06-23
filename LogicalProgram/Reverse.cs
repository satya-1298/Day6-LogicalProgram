using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Reverse
    {
        public void Display()
        {
            int rev=0,rem;
            Console.WriteLine("Enter a number");
            int n=Convert.ToInt32(Console.ReadLine());
            while(n!=0)
            {
                rem = n % 10;
                rev = rev * 10 + rem;
                n = n / 10;
            }
            Console.WriteLine("Reversed number is "+rev);
        }
    }
}
