using System;
namespace Lib
{
    public class TimeConversion
    {
        public static int GetTime(string s){
        bool conversion = DateTime.TryParse(s, out DateTime time);
        
        if (conversion)
        {
            var timeStr=time.ToString("HH:mm:ss");
            var hour=timeStr.Substring(0,2);
            return Convert.ToInt32(hour);
        }        
        return -1;

        }
    }
}