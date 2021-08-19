using Models;
using DL.Entities;
using System.Collections.Generic;
using System.Linq;
using System;

namespace DL
{
    public class PetRepo : IPetRepo
    {
        private petdbContext _context;
        public PetRepo(petdbContext context)
        {
            _context = context;
        }

        public List<Models.Cat> GetAllCats()
        {
            return _context.Cats.Select(
                cat => new Models.Cat(cat.Id, cat.Name, cat.ribcage, cat.leglength)
            ).ToList();
        }

        public Models.Cat AddACat(Models.Cat cat)
        {
            _context.Cats.Add(
                new Entities.Cat{
                    Name = cat.Name
                }
            );
            _context.SaveChanges();

            return cat;
        }

        public Models.Meal AddAMeal(Models.Meal meal)
        {
            _context.Meals.Add(
                new Entities.Meal {
                    Time = meal.Time,
                    FoodType = meal.FoodType,
                    CatId = meal.CatId
                }
            );
            _context.SaveChanges();

            return meal;
        }

        public Models.Cat SearchCatByName(string name)
        {
            Entities.Cat foundCat =  _context.Cats
                .FirstOrDefault(cat => cat.Name == name);
            if(foundCat != null)
            {
                return new Models.Cat(foundCat.Id, foundCat.Name,foundCat.ribcage ,foundCat.leglength);
            }
            return new Models.Cat();
        }

        public List<Models.Meal> GetMealsByCatId(int catId)
        {
            Console.WriteLine("I'm in DL, getting meals by Id, {0}", catId);
            return _context.Meals
                .Where(meal => meal.CatId == catId)
                .Select(meal => new Models.Meal{
                    Time = meal.Time,
                    FoodType = meal.FoodType,
                    CatId = (int)meal.CatId
                })
                .ToList();
        }

        public void DeleteACat(Models.Cat cat)
        {
            Entities.Cat catToDelete = new Entities.Cat
            {
                Id = cat.Id,
                Name = cat.Name
            };
            _context.Cats.Remove(catToDelete);
            _context.SaveChanges();
        }
    }
}