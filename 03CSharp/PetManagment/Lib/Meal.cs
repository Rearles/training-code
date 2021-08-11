using System;
namespace Lib
{
    public class Meal
    {
        public Meal() {
            this.timeFed = DateTime.Now;
        }
        public Meal(string foodName) : this()
        {
            this.foodName = foodName;
        }

        public string foodName {get; set;}
        public DateTime timeFed {get; set;}

        public override string ToString()
        {
            return $"Name: {this.foodName} \n Time: {this.timeFed}";
        }
    }
}