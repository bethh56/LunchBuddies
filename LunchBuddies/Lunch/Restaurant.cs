using System;
using System.Collections.Generic;
using System.Text;

namespace LunchBuddies.Lunch
{
    class Restaurant
    {

        private List<string> listOfRestaraunts = new List<string>() { "Chilis", "Hattie B's", "Baja Burrito", "Sunflower Cafe", "Rosepepper" };
        public string Name { get; set; }

        public Restaurant()
        {
            var random = new Random();
            int index = random.Next(listOfRestaraunts.Count);
            Name = listOfRestaraunts[index];
        }
    }
}
