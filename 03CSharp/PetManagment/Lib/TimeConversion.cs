using System;
namespace Lib
{
    public class TimeConversion
    {
        public static string GetTime(TimeSpan time){    
            if(time>=new TimeSpan(06,00,00) && time<new TimeSpan(12,00,00))
                return "Breakfast";
            else if(time>=new TimeSpan(12,00,00) && time<new TimeSpan(18,00,00))
                return "Lunch";
            else if(time>=new TimeSpan(18,00,00) && time<new TimeSpan(23,59,59))
                return "Dinner";
            else
                return "Snack time";
        }
    }
}