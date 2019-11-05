using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {

            
        }

        public static int Calculate(int n)
        {
            // exit solution
            if (n == 1)
            {
                return n;
            }else if (n > 1) 
            {
                return (Calculate * n);
            }
        }
    }
}
