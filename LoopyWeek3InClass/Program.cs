using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoopyWeek3InClass
{
    class Program
    {
        static void Main(string[] args)
        {
            //*BREAK - used for debugging LOGIC errors, click on margin, click start in menu not ctrl F5
            //click Step Into (arrow in menu)go line by line, and will show value in variables*
            //int x = 1;
            //while ( x < 10)
            //{
            //    Console.WriteLine(x);
            //    x++;
            //}
            //GUESS A NUMBER GAME - WHILE LOOPS
            //int lives = 3;
            //int magicNumber = 24;
            //bool isPlaying = true;
            //while (lives > 0 && isPlaying == true)
            //{
            //    Console.WriteLine("Guess a number");
            //    int usersGuess = int.Parse(Console.ReadLine());
            //    if (magicNumber == usersGuess)
            //    {
            //        Console.WriteLine("You guessed right!!!");
            //        isPlaying = false;
            //    }
            //    else
            //    {
            //    Console.WriteLine("Try again");
            //    lives--;
            //    Console.WriteLine("You have " + lives + " tries left.");
            //}
            //}

            //Print the numbers 1 to 100 
            //if the number is multiple of 3 print FIZZ
            //mult of 5 print BUZZ
            //mult of both print FIZZBUZZ

            for (int i= 1; i < 101; i++)
            {
                if (i % 3 == 0 && i % 5 == 0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                    Console.WriteLine(i);
            }

            Console.WriteLine("\n");

            //CREATE AN INT ARRAY WITH 10 ELEMENTS 
            //Find the mean of these elements and output the result to the console
            int[] tenNumbers = { 10, 15, 10, 9, 5, 4, 2, 9, 8, 12 };
            double sum=0;
            double mean=0;
            for (int i = 0; i < tenNumbers.Length; i++)
            {
                sum += tenNumbers[i];
            }
            mean = sum / tenNumbers.Length;
            Console.WriteLine(mean);


        }
    }
}
