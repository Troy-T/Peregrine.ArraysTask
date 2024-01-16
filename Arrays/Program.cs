using System;
using System.Collections;
using static System.Runtime.InteropServices.JavaScript.JSType;
namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Working with Arrays");
            int[] numbers = new[] { 1, 2, 3, 4, 5 };
            Console.WriteLine(numbers.Count());

            // Using the .Append() .Prepend() methods and converting it back to a string array
            numbers = numbers.Append<int>(10).ToArray();
            numbers = numbers.Prepend<int>(0).ToArray();
            for (int x = 0; x < numbers.Length; x++)
            {
                Console.Write($" {numbers[x]} , ");
            }

            Console.WriteLine("\nWorking with string array");
            string[] dayArray = new string[] { "Mon", "Tue" };
            dayArray = dayArray.Append("Wed").ToArray();
            // Display values
            foreach (var item in dayArray)
            {
                Console.Write(item + " , ");
            }
            Console.WriteLine("\nWorking with objects");
            object[] objs = new[] { "12", "2.5", "8", "monday", "tuesday" };
            foreach (var item in objs)
            {
                Console.Write(item + " , ");
            }

            /* TASKS:
             * a) Write code to sum the ints and doubles of:
             * object[] objs = new[] { "12", "2.5", "8", "monday", "tuesday" }
             * 
             * b) Write a program that asks user to enter an integer number,
             * then write a function that takes this integer and returns the sum
             * of the individual numbers.
             * 
             * c) Write a function that takes in a string and checks to see if it’s a palindrome.
             * 
             * d) Given an array of integers:
             * int[] rev = new[] { 1,2,3,4,5,6};
             * Write a function to save the integers in the same array in reverse order.
             */

            //Sum of the ints and doubles
            double sumDouble = 0;

            Console.WriteLine("\nSum of values:");

            foreach (var obj in objs)
            {
                try { sumDouble = Convert.ToDouble(obj); } 
                catch { Console.WriteLine("{0} could not be converted to double", obj); }
            }

            Console.WriteLine("Double sum: {0}\n\n", sumDouble);

            //Sum program:
            int total = 0;

            Console.WriteLine("Enter the string of numbers you wish to sum:");
            int sumInt = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("You've entered: {0}", sumInt);
            while (sumInt > 0)
            {
                total += sumInt % 10;
                sumInt /= 10;
            }
            Console.WriteLine("Sum of indivdual numbers: {0}", total);

            //Palindrome Check
            Console.WriteLine("\nEnter a string. That check will be checked to see if it's a vaild Palindrome.");
            char[] isPalindrome = Console.ReadLine().ToLower().ToCharArray();
            char[] isPalindromeReversed = isPalindrome.Reverse().ToArray();
            string stringPalindrome = new string(isPalindrome);
            string stringPalindromeReversed = new string(isPalindromeReversed);
            Console.WriteLine("{0} reversed is: {1}",stringPalindrome , stringPalindromeReversed);

            if (stringPalindrome == stringPalindromeReversed)
            {
                Console.WriteLine("{0} IS a palindrome", stringPalindrome);
            }
            else
            {
                Console.WriteLine("{0} IS NOT a palindrome", stringPalindrome);
            }

            //Reverse int Array
            int[] rev = new[] { 1, 2, 3, 4, 5, 6 };
            Console.WriteLine("\nArray to be reversed:");
            for (int i = rev.GetLowerBound(0); i <= rev.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, rev.GetValue(i));

            Array.Reverse(rev);

            Console.WriteLine("\nReversed array:");
            for (int i = rev.GetLowerBound(0); i <= rev.GetUpperBound(0); i++)
                Console.WriteLine("\t[{0}]:\t{1}", i, rev.GetValue(i));


            Console.ReadLine();
        }
    }
}
