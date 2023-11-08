using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConApp_ass4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
            if (number > 0)
            {
                Console.WriteLine("The Number is Positive");
            }
            else if (number < 0)
            {
                Console.WriteLine("The Number is Negative");
            }
            else
            {
                Console.WriteLine("The Number is Zero");
            }
            if(number%2==0)
            {
                Console.WriteLine("The number is even");
            }
            else
            {
                Console.WriteLine("The Number is Odd");
            }
            Console.ReadKey();
        }
    }
}
