using System.Collections.Generic;

namespace Models
{
    public class Cat
    {
        public Cat() {}
        public Cat(string name)
        {
            this.Name = name;
        }
        public Cat(int id, string name, float ribcage, float leglength) : this(name)
        {
            this.Id = id;
            this.leglength=leglength;
            this.ribcage=ribcage;
        }
        public int Id {get; set;}
        public string Name {get;set;}
        public float ribcage { get; set; }
        public float leglength { get; set; }
        public List<Meal> Meals {get;set;}
    }

}
