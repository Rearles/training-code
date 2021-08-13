using System;
using System.Collections.Generic;
namespace Lib
{
    public enum Gender{
        Male = 0 ,
        Female
    }
    public partial class Pet:IPet, IOmnivorous// Implementing interface
    {
        int id;
        public int Id{
            get => id;
            set => id=value;
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
        Gender gender;
        public Gender Gender { 
            get{
                return gender;
            } 
            set{
                gender=value;
            }
        }
        List<Meal> meals;
        List<Meal> IPet.Meals { 
            get{return meals;}
            set{meals=value;}
        }
        List<Meal> mealsOmnivorous;
        List<Meal> IOmnivorous.Meals{
            get{
                return mealsOmnivorous;
            }
            set{
                mealsOmnivorous=value;
            }
        }
        
        
    }
}
