using System;
using System.Collections.Generic;
using System.IO;

namespace LabZero
{
    class NumberRangeProgram
    {
        static void Main(string[] args)
        {
            int lowNumber = EnterPositiveNumber("Please enter the positive minimum value:");
            int highNumber = EnterNumberGreaterThan("Please enter the maximum value:", lowNumber);

            Console.WriteLine($"The difference between the two numbers is: {highNumber - lowNumber}");

            List<double> numbers = new List<double>();
            for (double i = lowNumber; i <= highNumber; i++)
            {
                numbers.Add(i);
            }

            using (StreamWriter writer = new StreamWriter("numbers.txt"))
            {
                for (int i = numbers.Count - 1; i >= 0; i--)
                {
                    writer.WriteLine(numbers[i]);
                }
            }

            // Read numbers back and print out the sum
            double sum = 0;
            foreach (double num in numbers)
            {
                sum += num;
            }
            Console.WriteLine($"The sum of the numbers is: {sum}");

            // Prime numbers between the two entered number
            Console.WriteLine("Prime numbers:");
            foreach (double num in numbers)
            {
                if (IsPrime(num))
                {
                    Console.WriteLine(num);
                }
            }
        }

        static int EnterPositiveNumber(string prompt)
        {
            int number;
            do
            {
                Console.WriteLine(prompt);
                number = int.Parse(Console.ReadLine());
            } while (number <= 0);
            return number;
        }

        static int EnterNumberGreaterThan(string prompt, int minValue)
        {
            int number;
            do
            {
                Console.WriteLine(prompt);
                number = int.Parse(Console.ReadLine());
            } while (number <= minValue);
            return number;
        }

        static bool IsPrime(double number)
        {
            if (number < 2)
            {
                return false;
            }

            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0)
                {
                    return false;
                }
            }
            return true;
        }
    }
}
