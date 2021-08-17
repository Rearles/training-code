using Models;
using DL.Entities;

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
                cat => new Models.Cat(cat.Id, cat.Name)
            ).ToList();
        }
    }
}