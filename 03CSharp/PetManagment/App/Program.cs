using System;
using Lib;
using System.Collections.Generic;
using System.Linq;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("time of the day "+ DateTime.Now.TimeOfDay);
            //CreateCat();
            //GetPets();
           // GetPetsFromDictionary();
            var pet=GetPetById(100);
            Console.WriteLine($"{pet.Id} {pet.Name}");

        }
        static Pet GetPetById(int id){
            var pets=Pet.InitializePet();
            
            var pet=pets.FirstOrDefault(x=>x.Id==id);

            if(pet!=null)
                return pet;
            else
                return null;
        }
        static void GetPets(){
            var pets = Pet.InitializePet();
            Console.WriteLine("#  |Pet Name| DOB    |  Gender   " );
            foreach (var pet in pets)
            {
                Console.WriteLine($"{pet.Id} {pet.Name} {(pet.Dob).ToShortDateString()} {pet.Gender}");
            }
        }
        static void GetPetsFromDictionary(){
            var pets=Pet.InitializePetDictionary();
            foreach (var key in pets.Keys)
            {
               Console.WriteLine($"{key} {pets[key].Id} {pets[key].Name}");
            }
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
