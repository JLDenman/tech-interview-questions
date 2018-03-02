using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tech_interview_questions
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1. Write a function that reverses a string w/o using built in functions
            /*
            Console.WriteLine("Type input here: ");
            string word = Console.ReadLine();
            char[] arr = word.ToCharArray();
            for (int i = arr.Length-1; i >=0 ; i--)
            {
                Console.Write(arr[i]);
            }
            */
            // 2. Write a function that displays the longest word in a sentence
            /*
            Console.WriteLine("Type your sentence here: ");
            string sentence = Console.ReadLine();
            string[] words= sentence.Split(' ');
            string largestword = "";

            for (int i = 0; i < words.Length; i++)
            {
                if (words[i].Length > largestword.Length)
                {
                    largestword = words[i];
                }
            }
            Console.Write($"The largest word is {largestword}.");
            */
            // 3. Write a function that will count the words from an 
            // input that only capitalizes every word starting at the second word such as :
            // thisIsAnExample
            /*
            Console.WriteLine("Type your input here");
            string input = Console.ReadLine();
            int count = 1; //we start from 1 because the first word isn't capitalized
            char[] arr = input.ToCharArray();

            for (int i = 0; i < arr.Length; i++)
            {
                if (char.IsUpper(arr[i]))
                {
                    count++;
                }

            }
            Console.WriteLine($"The wordcount is: {count} ");
            */
            // 4. Write a function that will draw a triangle the users input integers
            /*
            Console.WriteLine("Type in a number: ");
            int n = Convert.ToInt32(Console.ReadLine());
            int j;
            for (int i = 0; i <= n; i++)
            {
                for (j= 0; j < i; j++)
                {
                    Console.Write(i);
                    
                }
                Console.Write("\n");
            }
            */
            // 5. Copy a users array and print it out
            /*
            Console.WriteLine("What number of elements should your array have?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int[] arr2 = new int[n];
            Console.WriteLine("Give each element a value: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < n; i++)
            {
                arr2[i] = arr[i];
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write($"{arr2[i]} ");
            }
            */
            // 6. Convert uppercase letters to lower case and vice versa
            /*
            Console.WriteLine("Type input here: ");
            string input = Console.ReadLine();
            char[] swap = input.ToCharArray();
            char ch;

            for (int i = 0; i < swap.Length; i++)
            {
                ch = swap[i];
                if (Char.IsLower(ch))
                    Console.Write(Char.ToUpper(ch)); 
                else
                    Console.Write(Char.ToLower(ch));
            }
            */
            // 7.Identify the fraction of positive, negative and zeros of a users input
            /*
            Console.WriteLine("What number of elements should your array have?");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];
            int p=0, b=0, z=0;

            Console.WriteLine("Give each element a value: ");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"Element {i} : ");
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    p++;
                }
                else if (arr[i]<0)
                {
                    b++;
                }
                else
                {
                    z++;
                }
            }
            Console.WriteLine($"The fraction of positives is {p}/{n} ");
            Console.WriteLine($"The fraction of negatives is {b}/{n} ");
            Console.WriteLine($"The fraction of zeros is {z}/{n} ");
            */

            // 8.Check if an entered year is a leap year or not
            /*
            Console.WriteLine("Type a year: ");
            int y = Convert.ToInt32(Console.ReadLine());
            if ((y % 4 == 0 && y % 100 != 0) || (y % 400 == 0))
            {
                Console.WriteLine("{0} is a Leap Year", y);
            }
            else { Console.WriteLine("{0} is not a Leap Year", y);}
            */
            // 9. Swap two value without using a temp var or any additional memory
            /*
            Console.WriteLine("Type in a value: ");
            int one = Convert.ToInt32(Console.ReadLine()); 
            Console.WriteLine("Type in a second value, we'll swap them: ");
            int two = Convert.ToInt32(Console.ReadLine()); 
            one = one - two;
            two = one + two; 
            one = two - one;

            Console.Write($" The first value is now {one} and the second is {two}");
            */
            // 10. Print all ascii values and their numbers using a while loop
            /*
            int i = 0;
            while (i<=255)
            {
                Console.WriteLine($"{i} = {Convert.ToChar(i)}");
                i++;
            }
            */
            // 11. Calculate the cube of a users input
            /*
            Console.WriteLine("Give us a number, we calculate its cube: ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.Write($"The cube of {n} is {n * n * n}");
            */
            // 12. Display a string variable length 
            /*
            Console.WriteLine("Type something here: ");
            string input = Console.ReadLine();
            int len = 0;
            foreach (char letter in input)
            {
                len++;
            }
            Console.Write(len);
            */
            // 13. Count the vowels in a string
            /*
            Console.WriteLine("Type something here: ");
            string input = Console.ReadLine();
            int counter = 0;
            string lowerinput = input.ToLower();
            for (int i = 0; i < input.Length; i++)
            {
                if (lowerinput[i] =='a' || lowerinput[i] == 'e' || lowerinput[i] == 'i' ||
                    lowerinput[i] == 'o' || lowerinput[i] == 'u' )
                {
                    counter++;
                }
            }
            Console.WriteLine($"There are {counter} vowels in the users input" );
            */
        }

    }
    
}
