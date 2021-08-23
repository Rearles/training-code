using System;

namespace Models
{
    public class Meal
    {
        public Meal() { }
        public Meal(int catId, string foodType)
        {
            this.Time = DateTime.Now;
            this.CatId = catId;
            if (string.IsNullOrWhiteSpace(foodType))
            {
                throw new ArgumentException("invalid value for food type");
            }
            this.FoodType = foodType;
        }

        public DateTime Time { get; set; }
        public string FoodType { get; }
        public int CatId { get; set; }
    }
}
