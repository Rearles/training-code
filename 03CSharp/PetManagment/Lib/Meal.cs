using System;
namespace Lib
{
    public enum FoodType{
        WetFood,
        DryFood,
        RawFood,
        Treat
    }
    public class Meal
    {
        public Meal(DateTime Time)
        {
            this.Time=Time;
        }

        public FoodType FoodType {get; set;}
        public DateTime Time {get; set;}

        public override string ToString()
        {
            return $"Name: {this.FoodType} \nTime: {this.Time}";
        }

    }
}