using Models;
using BL;

namespace UI
{
    public class MainMenu : IMenu
    {
        private IPetBL _petbl;
        public MainMenu(IPetBL bl)
        {
            _petbl = bl;
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

                    default:
                        Console.WriteLine("We don't understand what you're doing");
                    break;
                }
            } while(repeat);
        }

        private void AddACat() 
        {
            Console.WriteLine("You're adding a cat");
        }
        private void FeedACat() 
        {
            Console.WriteLine("You are feeding a cat");
        }
        private void ViewAllCats() 
        {
            List<Cat> cats = _petbl.ViewAllCats();
            foreach(Cat cat in cats)
            {
                Console.WriteLine(cat.Name);
            }
        }
    }
}