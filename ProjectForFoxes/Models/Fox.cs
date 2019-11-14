using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjectForFoxes.Models
{
    public class Fox
    {
        public string Name { get; set; }
        public string Tricks { get; set; }
        public string Food { get; set; }
        public string Beverage { get; set; }
        public List<string> ListOfTricks { get; set; }
        public List<string> ListOfFood { get; set; }
        public List<string> ListOfBeverages { get; set; }

        public Fox(string name)
        {
            this.Name = name;
            this.Beverage = "Water";
            this.Food = "Peanuts";
            ListOfTricks = new List<string>();
            ListOfFood = new List<string>();
            ListOfBeverages = new List<string>();
        }
    }
}
