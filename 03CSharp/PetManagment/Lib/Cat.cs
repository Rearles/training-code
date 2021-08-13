using System;
namespace Lib
{
    public enum FurType{
        Long,
        Short,
        noFur
    }
    public enum CatType{
        Himalyan,
        Abyssian,
        British_Munchkin,
        Calico,
        Maine_Coons,
        Sphynx,
        Persian,
        American_Bobtail
    }
    public class Cat:Pet
    {
        public Cat()
        {
            Weight = 8.0;
            CatType=CatType.Himalyan;
            FurType=FurType.Long;
        }
        public double Weight { get; set; } // auto - property
        public CatType CatType { get; set; }
        public FurType FurType { get; set; }

        public new string GetDetails(){
            var result=base.GetDetails("Tolly");// calling parent class Getdetails method
            return result +" " + $"\nCat type: {CatType}\nWeight: {Weight} pounds\nFur type: {FurType}";
        }
       public override string GetMeal(Gender Gender)
        {
            Meal meal=new Meal(DateTime.Now);
            if(Gender == Gender.Male){
                if(TimeConversion.GetTime(meal.Time.TimeOfDay) == "Breakfast")
                    return $"125 gms of {FoodType.DryFood}, to munch munch!!";
                else if (TimeConversion.GetTime(meal.Time.TimeOfDay) == "Lunch")
                     return $"150 gms of {FoodType.WetFood} to Slurrp!! ";
                else if(TimeConversion.GetTime(meal.Time.TimeOfDay) == "Dinner")
                    return $"150 gms of {FoodType.RawFood}, mmm.... yumm!!";
                else
                    return $" {FoodType.Treat} time, yay!! ";
               }
            else
              {
                if(TimeConversion.GetTime(meal.Time.TimeOfDay) == "Breakfast")
                    return $"80 gms of {FoodType.DryFood}, to munch munch!!";
                else if (TimeConversion.GetTime(meal.Time.TimeOfDay) == "Lunch")
                     return $"120 gms of {FoodType.WetFood} to Slurrp!! ";
                else if(TimeConversion.GetTime(meal.Time.TimeOfDay) == "Dinner")
                    return $"100 gms of {FoodType.RawFood}, mmm.... yumm!!";
                else
                    return $" {FoodType.Treat} time, yay!! ";
              }
        }
    }
}