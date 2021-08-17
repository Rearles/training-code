using System.Collections.Generic;

using Models;

namespace DL
{
    public interface IPetRepo
    {
        List<Cat> GetAllCats();
    }
}