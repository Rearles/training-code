using System;
using System.Collections.Generic;
namespace Lib
{
    public enum Gender{
        Male = 0 ,
        Female
    }
    public class Pet
    {
        int id;
        public int Id{
            get{
                return id;
            }
            set{
                id=value;
            }
        }
        string name;
        public string Name { 
            get{
                if(!String.IsNullOrEmpty(name))
                    return name;
                else
                    throw new NullReferenceException();
            }
            set{
                name=value;
            } 
         }
       
        DateTime dob;
        public DateTime Dob { 
            get{
                return dob;
        }
            set{
                dob=value;
            } 
       }
        Gender? gender;
        public Gender? Gender { 
            get{
                return gender;
            } 
            set{
                gender=value;
            }
        }
        List<Meal> meals;
        public List<Meal> Meals { 
            get{return meals;}
            set{meals=value;}
        }
        public string GetDetails(){
           return $"Pet ID:{id}\n Pet name: {name}\n Birthday:{dob.ToShortDateString()}\n Gender: {gender}";
        }
    }
}
