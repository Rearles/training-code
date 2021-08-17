using Models;
using DL;
using System.Collections.Generic;

namespace BL
{
    public class PetBL : IPetBL
    {
        private IPetRepo _repo;

        public PetBL(IPetRepo repo)
        {
            _repo = repo;
        }
        public List<Cat> ViewAllCats()
        {
            return _repo.GetAllCats();
        }
    }
}