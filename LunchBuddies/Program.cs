using LunchBuddies.Lunch;
using System;
using System.Collections.Generic;
using System.Net.Http.Headers;

namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            var companions = new List<LunchBuddy>();
            var listOfFirstNames = new List<string>() { "Beth", "Brandon", "John", "Cameron", "Joey" };
            var listOfLastNames = new List<string>() { "Nielsen", "Toppins", "Jones", "Smith", "Roberts" };

            for (int i = 0; i < listOfFirstNames.Count; i++)
            {
                companions.Add(new LunchBuddy(listOfFirstNames[i], listOfLastNames[i]));
            }

            companions[0].eat();
            companions[0].eat("pizza");
            companions[0].eat(companions);
            companions[0].eat("burger", companions);

        }
    }
}
