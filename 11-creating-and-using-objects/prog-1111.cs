/*
|--------------------------------------------------------------------------
| Chapter 11. Creating and Using Objects
|--------------------------------------------------------------------------
|
| Exercise 11:
|
|     Write a program, which generates a random advertising message
|     for some product. The message has to consist of laudatory phrase,
|     followed by a laudatory story, followed by author (first
|     and last name) and city, which are selected from predefined lists.
|     For example, let’s have the following lists:
|
|       - Laudatory phrases: {"The product is excellent.", "This is
|         a great product.", "I use this product constantly.",
|         "This is the best product from this category."}.
|
|       - Laudatory stories: {"Now I feel better.", "I managed
|         to change.", "It made some miracle.", "I can’t believe it,
|         but now I am feeling great.", "You should try it, too.
|         I am very satisfied."}.
|
|       - First name of the author: {"Dayan", "Stella", "Hellen",
|         "Kate"}.
|
|       - Last name of the author: {"Johnson", "Peterson", "Charls"}.
|
|       - Cities: {"London", "Paris", "Berlin", "New York", "Madrid"}.
|
|     Then the program would print randomly generated advertising
|     message like the following:
|
|       * I use this product constantly. You should try it, too.
|         I am very satisfied. -- Hellen Peterson, Berlin
|
| Solutions and Guidelines:
|
|     Use the class System.Random and its method Next(...) to select
|     a random laudatory phrase, laudatory story, first name, last name
|     and city and combine them.
|
*/

using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            string[] laudatoryPhrases = {"The product is excellent.", "This is a great product.",
                "I use this product constantly.", "This is the best product from this category."};

            string[] laudatoryStories = {"Now I feel better.", "I managed to change.",
                "It made some miracle.", "I can’t believe it, but now I am feeling great.",
                "You should try it, too. I am very satisfied."};

            string[] authorsFirstNames = { "Dayan", "Stella", "Hellen", "Kate" };

            string[] authorsLastNames = { "Johnson", "Peterson", "Charls" };

            string[] cities = { "London", "Paris", "Berlin", "New York", "Madrid" };

            Random rnd = new Random();

            Console.WriteLine("{0} {1} -- {2} {3}, {4}", laudatoryPhrases[rnd.Next(0, 3)], laudatoryStories[rnd.Next(0, 4)],
                authorsFirstNames[rnd.Next(0, 3)], authorsLastNames[rnd.Next(0, 2)], cities[rnd.Next(0, 4)]);
        }
    }
}
