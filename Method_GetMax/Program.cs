using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_GetMax
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Max number application");

            Console.Write("Insert first number: ");
            int FirstNumber = int.Parse(Console.ReadLine());

            Console.Write("Insert second number: ");
            int SecondNumber = int.Parse(Console.ReadLine());

            int max = GetMax(FirstNumber, SecondNumber);
            Console.WriteLine("The maximum number is: " + max);
            Console.ReadLine();

        }

        static int GetMax(int number1, int number2)
        {
            return Math.Max(number1, number2);
        }

    }
}
