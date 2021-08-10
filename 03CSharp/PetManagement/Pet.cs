using System;
using System.Collections.Generic;

namespace PetManagement
{
    public class Pet
    {
        public Pet() {
            Console.WriteLine("Empty Constuctor has been called");
            Random rand = new Random();
            this.id = rand.Next();
            this.gender = null;
            this.Meals = new List<Meal>();
        }
        public Pet(string name) : this()
        {
            Console.WriteLine("Constuctor with name has been called");
            this.name = name;
        }

        // 1. variables 
        public int id;
        public string name;
        public System.DateTime dob;
        public Gender? gender;

        public List<Meal> Meals;
        // 2. Methods
        public string GetDetails(){
           return $"Pet ID:{id}\n Pet name: {name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}";
        }
    }
    public enum Gender{
        Male = 0 ,
        Female
    }

    public class Meal {
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