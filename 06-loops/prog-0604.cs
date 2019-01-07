/*
|--------------------------------------------------------------------------
| Chapter 6. Loops
|--------------------------------------------------------------------------
|
| Exercise 4:
|
|     Write a program that prints all possible cards from a standard
|     deck of cards, without jokers (there are 52 cards:
|     4 suits of 13 cards).
|
| Solutions and Guidelines:
|
|     Number the cards from 2 to 14 (these numbers will match
|     the cards 2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K, A).
|     Number the suits from 1 to 4 (1 – club, 2 – diamond,
|     3 – heart and 4 – spades). Now you can use the two nested
|     loops and print each of the cards with two switch statements.
|
*/

using System;

namespace Program
{
    class Program
    {
        static void Main(string[] args)
        {
            object[] deck = { 2, 3, 4, 5, 6, 7, 8, 9, 10, 'J', 'Q', 'K', 'A' };

            Console.WriteLine("Please, enter which suit is wanted to be displayed.\n");
            Console.WriteLine("1 for Club, 2 for Diamond, 3 for Heart, 4 for Spades.");
            Console.Write("\nChoice: ");
            int choice = int.Parse(Console.ReadLine());
            Console.WriteLine();

            switch (choice)
            {
                case 1:
                    Console.Write("Club Cards - ");
                    foreach (var card in deck)
                    {
                        Console.Write("{0} ", card);
                    }
                    break;
                case 2:
                    Console.Write("Diamond Cards - ");
                    foreach (var card in deck)
                    {
                        Console.Write("{0} ", card);
                    }
                    break;
                case 3:
                    Console.Write("Heart Cards - ");
                    foreach (var card in deck)
                    {
                        Console.Write("{0} ", card);
                    }
                    break;
                case 4:
                    Console.Write("Spades Cards - ");
                    foreach (var card in deck)
                    {
                        Console.Write("{0} ", card);
                    }
                    break;
                default:
                    Console.WriteLine("Unidentified input. Please, try again.");
                    break;
            }
            Console.WriteLine();
        }
    }
}