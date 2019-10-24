using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1
            //Generate all possible combinations of three digit number.
            //Let’s have number XXX, each digit can have a value 0-9.
            //Generate all possible combinations and print them.
            //Example: 001, 002, 003, …, 010, 011, …., 099, 100, 101, ….999

            Console.WriteLine("Click any button to see all combinations for 3 digit number: ");
            DigitGenerator testDigitGenerator = new DigitGenerator();
            testDigitGenerator.Generator();

            Console.ReadKey();

            //Task 2
            //Generate array of random integer numbers.
            //Go through all generated numbers and find numbers that are divisible by 2, 3 and 7.
            //Store those numbers in other arrays. Print the result like:
            //Numbers divisible by 2: [2, 4, 6, ….]
            //Numbers divisible by 3: [3, 6, 9, ….]
            //Numbers divisible by 7: [7, 14, ...]
            //Numbers that are not divisible: [....]
            Console.WriteLine("Click any button to see numbers divisiable by 2,3,7 from randomly generated array");
            DivisableByNumbers testDivisability = new DivisableByNumbers();

            
            var randomNumbers = testDivisability.GenerateNumbers();

            var numbersDivisbleby2 = testDivisability.CheckDivisability(randomNumbers, 2);
            var numbersDivisbleby3 = testDivisability.CheckDivisability(randomNumbers, 3);
            var numbersDivisbleby7 = testDivisability.CheckDivisability(randomNumbers, 7);

            Console.WriteLine($"Numbers divisible by 3: ");
            numbersDivisbleby3.ForEach(i => Console.Write($"{i.ToString()}, "));

            Console.WriteLine($"Numbers divisible by 2: ");
            numbersDivisbleby2.ForEach(i => Console.Write($"{i.ToString()}, "));

            Console.WriteLine($"Numbers divisible by 7: ");
            numbersDivisbleby7.ForEach(i => Console.Write($"{i.ToString()}, "));

            Console.ReadKey();

        }
    }
}
