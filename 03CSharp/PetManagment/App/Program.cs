using System;
using Lib;
using System.Collections.Generic;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("time of the day "+ DateTime.Now.TimeOfDay);
            CreateCat();
        }
        static IPet CreatePet(){
            IPet pet1 = new Cat();//Upcasting
           // assign values to the variables
            Console.Write("\nPlease enter your Pet name: ");
            pet1.Name = Console.ReadLine();
            Console.Write("\nPlease enter your Pet date of birth (yyyy/mm/dd): ");
            pet1.Dob = Convert.ToDateTime(Console.ReadLine());

                Console.Write("\nPlease enter your Pet's Gender (press <1> for Female and press <0> for male): ");
                string gender = Console.ReadLine();
                if(gender == "0")
                    pet1.Gender = Gender.Male;
                else if(gender == "1") 
                    pet1.Gender = Gender.Female;
                else 
                    Console.Write("incorrect Gender (press <1> for Female and press <0> for male)"); 

            // call the method
            string details=pet1.GetDetails();
            Console.WriteLine(pet1.GetDetails());
            return pet1;
        }
        static void CreateCat(){
            Cat pet1 = new Cat();
            Console.Write("\nPlease enter your Pet name: ");
            pet1.Name = Console.ReadLine();
            Console.Write("\nPlease enter your Pet date of birth (yyyy/mm/dd): ");
            pet1.Dob = Convert.ToDateTime(Console.ReadLine());
                Console.Write("\nPlease enter your Pet's Gender (press <1> for Female and press <0> for male): ");
                string gender = Console.ReadLine();
                if(gender == "0")
                    pet1.Gender = Gender.Male;
                else if(gender == "1") 
                    pet1.Gender = Gender.Female;
                else 
                    Console.Write("incorrect Gender (press <1> for Female and press <0> for male)");
            Console.WriteLine(pet1.GetDetails(101,pet1.Name));// calling the overload in Pet class
            Console.WriteLine("Please feed your pet with "+ pet1.GetMeal(pet1.Gender));
        }
    }
}
