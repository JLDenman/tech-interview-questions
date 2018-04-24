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
            /*
           

            // 14. Return the Hypotenuse of a right triankle after given two sides
            /*
            Console.WriteLine("Enter side a: ");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Enter side b: ");
            double b = Convert.ToDouble(Console.ReadLine());
            double result = Math.Pow(a, 2) + Math.Pow(b, 2);
            result = Math.Sqrt(result);
            Console.WriteLine(result);
            */

            // 15.Display 10 random numbers between 0 and 30 of which there can't be a duplicate number


            // 16.Given a year is the year a leap year and ensure the user provides legitimate value

            /*
            Console.WriteLine("Enter a year: ");
            int year = 1900;
            int.TryParse(Console.ReadLine(), out year);
            if (year % 4 == 0)
            {
                Console.WriteLine("Yes, it;s a leap year!");
            }
            else { Console.WriteLine("No it's not a leap year."); }
            */

            // 17. Number, has to be greater than nine, print out the last number as a word 
            /*
            Console.WriteLine("Input a number greater than 9 : ");
            int number = Convert.ToInt32(Console.ReadLine());
            
            if (number>9)
            {
                int result = number % 10;

                switch (result)
                {
                    case 0:
                        Console.WriteLine("zero");
                        break;
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("three");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;

                }
            }
            else
            { Console.WriteLine("Please try again, number has to be greater than 9. "); }
            */

            // 18.Write a programm that does integer division without using % or division
            /*
            Console.WriteLine("Type in the number: ");
            int numerator = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("What are we dividing it by?");
            int denom = Convert.ToInt32(Console.ReadLine());
            int result = 0;

            while (numerator>= denom)
            {
                numerator -= denom;
                result++;
            }
            Console.WriteLine(result);
            */

            //Write a program that will reverse a number 
            /*
            Console.WriteLine("number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int reverse = 0;

            while (num !=0)
            {
                reverse *= 10;
                reverse += (num % 10);
                num = num / 10;
            }
            */
            // 19. Find the frequency of the word "the" in a string
            /* {
                 Console.WriteLine("Enter the string: ");
                 string s1 = Console.ReadLine();
                 Console.WriteLine(CountStringOccurences(s1, "the"));
                 Console.ReadLine();
             }
             public static int CountStringOccurences(string text, string pattern)
             {
                 int count = 0;
                 int i = 0;
                 while (i= text.IndexOf(pattern,i)!=-1)
                 {
                     i += pattern.Length;
                     count++;
                 }
                 return count;
             }
             */
            // Find the unique elements in an array
            /*
            int tempy = 0;
            int counter = 0;
            int[] array = new int[5] { 2, 2, 1, 3, 4 };

            foreach (int e in array)
            {
                int count = 0;

                foreach (int tmp in array)//foreach return the index and not the actual value;
                {
                    if (e==tmp)
                    {
                        count++;
                        tempy=array[tmp];
                    }
                }
                    if (count < 2) // that means it is unique as requested in the question
                    {
                        counter = counter + count;
                        Console.WriteLine(array.ElementAt(tempy));
                    }
                
            }
            Console.WriteLine($"Total number of unique elements {counter}.");
            */

            // Convert upper to lower case without using additional memory and vice versa
            /*
            Console.WriteLine("Enter a string.");
            string input = Console.ReadLine();
            foreach (char c in input)
            {
                Convert.ToInt32(c);
                if (c >= 65 && c <= 90)
                {
                    Console.Write(Convert.ToChar(c + 32));
                }
                else if (c >= 97 && c <= 122)
                {
                    Console.Write(Convert.ToChar(c - 32));
                }
            }
            Console.ReadLine();
            */

            


        }

    }
    
}
