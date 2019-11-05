using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenerateParamid
{
    class Program
    {
        static void Main(string[] args)
        {

            string n = "*";

            for (int i = 0; i < 7; i++)
            {
                Console.WriteLine(n);

                for (int j = 0; j <= i; j++)
                {
                    Console.Write(" ");
                }

            }
            Console.Read();

        }
    }
}
