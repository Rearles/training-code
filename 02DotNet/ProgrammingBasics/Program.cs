using System;

namespace ProgrammingBasics
{
    class Program
    {
      
        static void Main(string[] args)
        {
            #region type conversion
            /*long a = 10;
            int b = (long) a; // explicit conversion
            int b = long.Parse(a); // explicit conversion
            int b = Convert.ToInt64(a); // explicit conversion

            int x = int.MaxValue; //2147483647
            short y = (short)x;
            Console.WriteLine(y);*/
            #endregion
            
            Input();

        }
        static void Input(){
            CSharpBasics obj = new CSharpBasics();
            Console.WriteLine("-------Addition Program------------");
            Console.Write(" Please enter a number : ");
            float a = float.Parse(Console.ReadLine());
            Console.Write(" Please enter another number for addition : ");
            float b = float.Parse(Console.ReadLine());
            Console.Write($"The addition of {a} and {b} is {obj.Add(a,b)}");
        }
    }
}
