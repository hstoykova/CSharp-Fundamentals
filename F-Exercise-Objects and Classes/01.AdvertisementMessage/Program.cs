﻿/*
3

 */

using System;

namespace _01.AdvertisementMessage
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] phrases =
            {
                "Excellent product.", 
                "Such a great product.", 
                "I always use that product.", 
                "Best product of its category.", 
                "Exceptional product.", "I can't live without this product."
            };
            string[] events =
            {
                "Now I feel good.",
                "I have succeeded with this product.",
                "Makes miracles. I am happy of the results!",
                "I cannot believe but now I feel awesome.",
                "Try it yourself, I am very satisfied.",
                "I feel great!"
            };
            string[] authors =
            {
                "Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"
            };
            string[] cities =
            {
                "Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"
            };

            int number = int.Parse(Console.ReadLine());

            Random random = new Random();

            for (int i = 0; i < number; i++)
            {
                int phraseIndex = random.Next(0, phrases.Length);
                string newPhrase = phrases[phraseIndex];

                int eventIndex = random.Next(0, events.Length);
                string newEvent = events[eventIndex];

                int authorIndex = random.Next(0, authors.Length);
                string newAuthor = authors[authorIndex];

                int cityIndex = random.Next(0, cities.Length);
                string newCity = cities[cityIndex];

                Console.WriteLine($"{newPhrase} {newEvent} {newAuthor} – {newCity}.");
            }
        }
    }
}