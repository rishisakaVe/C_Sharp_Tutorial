using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            // Hello World
            Console.WriteLine("Hello, World!");

            // Fizz Buzz until 100

            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }

            //Make a triangle

            int triangleSize = 4;
            int edge = triangleSize + 1;

            while (triangleSize != 0)
            {
                for (int i = 0; i < edge - triangleSize; i++)
                {
                    Console.Write("$");
                }
                Console.WriteLine();
                triangleSize--;
            }

            // To set up a break point and see the result on console
            Console.WriteLine("Stop");
        }
    }
}
