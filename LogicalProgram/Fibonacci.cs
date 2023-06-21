using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalProgram
{
    public class Fibonacci
    {
        public void Series()
        {
            int a = 0;
            int b = 1;
           
            Console.WriteLine("Enter a value");
            int n=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(b);
            for (int i = 0; i <=n; i++) 
            {
                int f = a + b;
                Console.WriteLine(f);
                a = b;
                b = f;
            }
        }
    }
}
