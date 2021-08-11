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
            var result=base.GetDetails();// calling parent class Getdetails method
            return result +" " + $"\nCat type: {CatType}\nWeight: {Weight} pounds\nFur type: {FurType}";
        }
        public override string GetMeal(Gender Gender)
        {
            Meal meal=new Meal(DateTime.Now);
            if(Gender == Gender.Male){
                if(TimeConversion.GetTime(meal.Time.ToLongDateString())<12&&TimeConversion.GetTime(meal.Time.ToLongDateString())>5)
                    return $"125 gms of {FoodType.DryFood}";
                else if (TimeConversion.GetTime(meal.Time.ToLongDateString())>=12 && TimeConversion.GetTime(meal.Time.ToLongDateString())<=18)
                     return $"150 gms of {FoodType.WetFood}";
                else 
                    return $"150 gms of {FoodType.RawFood}";
               }
            else
              {
                if(TimeConversion.GetTime(meal.Time.ToLongDateString())<12 && TimeConversion.GetTime(meal.Time.ToLongDateString())>5)
                    return $"100 gms of {FoodType.DryFood}";
                else if (TimeConversion.GetTime(meal.Time.ToLongDateString())>=12 && TimeConversion.GetTime(meal.Time.ToLongDateString())<=18)
                     return $"120 gms of {FoodType.WetFood}";
                else 
                    return $"100 gms of {FoodType.RawFood}";
              }
        }

    }
}