using CanIBringMyDog.Models;

namespace CanIBringMyDog.Interfaces.Repositories
{
    public interface IDogFriendlyPlaceRepository
    {
        void Add(DogFriendlyPlace place);
        void Delete(int id);
        IEnumerable<DogFriendlyPlace> GetAll();
        DogFriendlyPlace GetById(int id);
        void Update(DogFriendlyPlace place);
    }
}