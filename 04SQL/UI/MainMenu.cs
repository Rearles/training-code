using Models;
using BL;
using System;
using System.Collections.Generic;
using Serilog;

namespace UI
{
    public class MainMenu : IMenu
    {
        
        private IPetBL _petbl;
        public MainMenu(IPetBL bl)
        {
            _petbl = bl;
            Log.Logger=new LoggerConfiguration()
                            .MinimumLevel.Debug()
                            .WriteTo.Console()
                            .WriteTo.File("../logs/petlogs.txt", rollingInterval:RollingInterval.Day)
                            .CreateLogger();
            Log.Information("UI begining");
        }

        public void Start()
        {
            bool repeat = true;
            do
            {
                Console.WriteLine("Welcome to Cat Manager!");
                Console.WriteLine("[0] Exit");
                Console.WriteLine("[1] Add a cat");
                Console.WriteLine("[2] Feed a cat");
                Console.WriteLine("[3] View all cats");
                Console.WriteLine("[4] Search for a cat");
                Console.WriteLine("[5] View Meals for a cat");

                switch(Console.ReadLine())
                {
                    case "0":
                        Console.WriteLine("Goodbye!");
                        repeat = false;
                    break;

                    case "1":
                        AddACat();
                    break;

                    case "2":
                        FeedACat();
                    break;

                    case "3":
                        ViewAllCats();
                    break;

                    case "4":
                        SearchCatByNameUI();
                    break;

                    case "5":
                        ViewMealsByCat();
                    break;

                    default:
                        Console.WriteLine("We don't understand what you're doing");
                    break;
                }
            } while(repeat);
        }

        private void AddACat() 
        {
            string input;
            Cat catToAdd;

            Console.WriteLine("Enter details for the cat to add");
            
            do
            {
                Console.WriteLine("Name: ");
                input = Console.ReadLine();

            } while(String.IsNullOrWhiteSpace(input));


            catToAdd = new Cat(input);
            catToAdd = _petbl.AddACat(catToAdd);

            Console.WriteLine($"{catToAdd.Name} was successfully added!");
        }
        private void FeedACat() 
        {
            List<Cat> cats = _petbl.ViewAllCats();
            string prompt = "Select a cat to feed";
            Cat selectedCat = SelectACat(cats, prompt);
            string foodType;
            if(selectedCat is not null)
            {
                Console.WriteLine("You selected " + selectedCat.Name);
                
                do
                {
                    Console.WriteLine("What type of food do you want to feed them?");
                    foodType = Console.ReadLine();
                } while(String.IsNullOrWhiteSpace(foodType));

                Meal mealToFeed = new Meal(selectedCat.Id, foodType);

                try
                {
                    mealToFeed = _petbl.AddAMeal(mealToFeed);
                    //Console.WriteLine("meal has been added! " + mealToFeed.Time);
                    Log.Debug("meal has been added! " + mealToFeed.Time);
                }
                catch (Exception ex)
                {
                    Log.Error(ex, "Cat wasn't been fed, something wrong happened");
                    //Console.WriteLine(ex);
                }
                finally{
                    Log.CloseAndFlush();
                }
            }
        }

        private void ViewAllCats() 
        {
            List<Cat> cats = _petbl.ViewAllCats();
            foreach(Cat cat in cats)
            {
                var fbmi= HealthStatus.Fbmi(cat.ribcage, cat.leglength);
                Console.WriteLine($"{cat.Name}");
                Console.WriteLine($"{HealthStatus.CatHealth(fbmi)}");
                Console.WriteLine("-----------------------------------------");
            }
        }

        private Cat SelectACat(List<Cat> cats, string prompt)
        {
            Console.WriteLine(prompt);

            int selection;
            bool valid = false;

            do {
                //loops through the cats list and print the names
                for(int i = 0; i < cats.Count; i++)
                {
                    Console.WriteLine($"[{i}] {cats[i].Name}");
                }

                //trying to parse user input into integer
                //capture the bool return val in valid variable
                //and the parsed integer in selection
                valid = int.TryParse(Console.ReadLine(), out selection);

                //this means that the parsing to integer has been successful and is within list's range
                if(valid && (selection >= 0 && selection < cats.Count))
                {
                    return cats[selection];
                }

                Console.WriteLine("Enter a valid number");
            } while(true);
        }

        private void SearchCatByNameUI()
        {
            string input;
            Console.WriteLine("Enter the name of the cat to search: ");
            input = Console.ReadLine();

            Cat foundCat = _petbl.SearchCatByName(input);
            
            if(foundCat.Name is null)
            {
                Console.WriteLine($"{input} is missing, please return them asap :'(");
            }
            else {
                Console.WriteLine("We found the cat! {0}", foundCat.Name);
            }
        }

        private void ViewMealsByCat()
        {
            //ToDo: Somebody fix it 
            // compiler is trying to do a weird cast from int to string for no reason
            // string input;
            // Console.WriteLine("Enter the name of the cat to view meals: ");
            // input = Console.ReadLine();
            // Cat foundCat = _petbl.SearchCatByName(input);

            List<Cat> cats = _petbl.ViewAllCats();
            Cat foundCat = SelectACat(cats, "Pick a cat to feed");

            List<Meal> meals = _petbl.GetMealsByCatId(foundCat.Id);
            foreach(Meal meal in meals)
            {
                Console.WriteLine($"Type: {meal.FoodType} Time: {meal.Time}");
            }
        }
    }
}