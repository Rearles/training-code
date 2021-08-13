using System;
using System.Collections.Generic;
namespace Lib
{
    public partial class Pet
    {
        /// <summary>
        /// Explicit implementation of Interface
        /// </summary>
        /// <returns></returns>
        string IPet.GetDetails(){
           return $"Pet ID:{id}\n Pet name: {name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}";
        }

        string IOmnivorous.GetDetails(){
            return $"Pet ID:{id}\n Pet name: {name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}";
        }
        /// <summary>
        /// This method takes string input and returns the output as formatted String
        /// </summary>
        /// <param name="name">String name</param>
        /// <returns>String - formatted string</returns>
        public string GetDetails(string name){
           return $"Pet ID:{id}\n Pet name: {this.name=name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}";
        }
        public string GetDetails(int id, string name){
           return $"Pet ID:{this.id=id}\n Pet name: {this.name=name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}";
        }
        public string GetDetails(int id, string name, Gender gender){
           return $"Pet ID:{this.id=id}\n Pet name: {this.name=name}\n Birthday:{dob.ToShortDateString()}\n Gender: {this.gender=gender}";
        }
        
        //public abstract string GetMeal(Gender Gender);
        public virtual string GetMeal(Gender Gender){
            Meal meal=new Meal(DateTime.Now);
            if(Gender == Gender.Male)
                return $"125 gms of {FoodType.DryFood}";    
            else
                return $"100 gms of {FoodType.DryFood}";               
        }

        public static IEnumerable<Pet> InitializePet(){
           
            /*Stack<Pet> pets=new Stack<Pet>();
            pets.Push(new Pet(){Id=100,Name="Snow",  Dob=DateTime.Now, Gender=Gender.Male});
            pets.Push(new Pet(){Id=101,Name="Tolly", Dob=DateTime.Now, Gender=Gender.Male});
            pets.Push(new Pet(){Id=102,Name="Baxter",Dob=DateTime.Now, Gender=Gender.Female});
            pets.Push(new Pet(){Id=103,Name="Smarty",Dob=DateTime.Now, Gender=Gender.Male});*/
            /*Queue<Pet> pets =new Queue<Pet>();
            pets.Enqueue(new Pet(){Id=100,Name="Snow",  Dob=DateTime.Now, Gender=Gender.Male});
            pets.Enqueue(new Pet(){Id=101,Name="Tolly", Dob=DateTime.Now, Gender=Gender.Male});
            pets.Enqueue(new Pet(){Id=102,Name="Baxter",Dob=DateTime.Now, Gender=Gender.Female});
            pets.Enqueue(new Pet(){Id=103,Name="Smarty",Dob=DateTime.Now, Gender=Gender.Male});*/
            List<Pet> pets=new List<Pet>(){
                new Pet(){Id=100,Name="Snow",  Dob=DateTime.Now, Gender=Gender.Male},
                new Pet(){Id=101,Name="Tolly", Dob=DateTime.Now, Gender=Gender.Male},
                new Pet(){Id=102,Name="Baxter",Dob=DateTime.Now, Gender=Gender.Female},
                new Pet(){Id=103,Name="Smarty",Dob=DateTime.Now, Gender=Gender.Male}
            };
            pets.Add(new Pet(){Id=104,Name="Rover",Dob=DateTime.MaxValue, Gender=Gender.Female});
            return pets;
        }
        public static IDictionary<int,Pet> InitializePetDictionary(){
            Dictionary<int,Pet> pets=new Dictionary<int, Pet>();
            pets.Add(1,new Pet(){Id=100,Name="Snow",  Dob=DateTime.Now, Gender=Gender.Male});
            pets.Add(2,new Pet(){Id=101,Name="Tolly", Dob=DateTime.Now, Gender=Gender.Male});
            pets.Add(3,new Pet(){Id=102,Name="Baxter",Dob=DateTime.Now, Gender=Gender.Female});
            pets.Add(4, new Pet(){Id=103,Name="Smarty",Dob=DateTime.Now, Gender=Gender.Male});
            return pets;
        }
    }
}