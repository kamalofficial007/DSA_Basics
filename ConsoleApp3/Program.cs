using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 12, 35, 1, 10, 34, 1 };
            Console.WriteLine(FindSecondLargest(numbers));
            string input = "Hello World";
            Dictionary<char, int> charCount = new Dictionary<char, int>();

            foreach (char c in input)
            {
                if (c != ' ') // Ignoring spaces
                {
                    if (charCount.ContainsKey(c))
                    {
                        charCount[c]++;
                    }
                    else
                    {
                        charCount[c] = 1;
                    }
                }
            }

            foreach (var pair in charCount)
            {
                Console.WriteLine($"Character: {pair.Key}, Count: {pair.Value}");
            }
        }
        static int FindSecondLargest(int[] arr)
        {
            if (arr.Length < 2)
            {
                throw new ArgumentException("Array must contain at least two elements.");
            }

            int largest = int.MinValue;
            int secondLargest = int.MinValue;

            foreach (int num in arr)
            {
                if (num > largest)
                {
                    secondLargest = largest;
                    largest = num;
                }
                else if (num > secondLargest && num != largest)
                {
                    secondLargest = num;
                }
            }

            if (secondLargest == int.MinValue)
            {
                throw new InvalidOperationException("No distinct second largest element found.");
            }

            return secondLargest;
        }
    }
}
