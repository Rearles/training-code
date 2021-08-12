using System;
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
    }
}