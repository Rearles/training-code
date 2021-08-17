using Models;

namespace DL
{
    public interface IPetRepo
    {
        List<Cat> GetAllCats();
    }
}