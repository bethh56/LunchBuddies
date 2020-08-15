using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.Lunch
{
    class LunchBuddy : Restaurant
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public Food food { get; set; }

        //private List<string> listOfRestaraunts = new List<string>() { "Chilis", "Hattie B's", "Baja Burrito", "Sunflower Cafe", "Rosepepper" };

        public LunchBuddy(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public void eat()
        {
            Console.WriteLine($"{FirstName} went to {Name} today for lunch");
        }
        public void eat(string food)
        {
            Console.WriteLine($"{FirstName} had {food} to eat at the resturaunt.");
        }
        public void eat(List<LunchBuddy> companions)
        {
            var resturauntName = Name;
            foreach (var item in companions)
            {
                if(item.FirstName != FirstName && item.LastName != LastName)
                    Console.WriteLine($"{item.FirstName} was also there.");
            }
        }

        public void eat(string food, List<LunchBuddy> companions)
        {
            var resturauntName = Name;
            Console.WriteLine($"{FirstName} had {food} to eat at the {Name}.");
            foreach (var item in companions)
            {
                if (item.FirstName != FirstName && item.LastName != LastName)
                    Console.WriteLine($"{item.FirstName} was also there.");
            }
        }
    }
}
