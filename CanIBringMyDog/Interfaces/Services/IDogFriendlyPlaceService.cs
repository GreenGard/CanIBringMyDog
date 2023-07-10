using CanIBringMyDog.Models;

namespace CanIBringMyDog.Interfaces.Services
{
    public interface IDogFriendlyPlaceService
    {
        void AddDogFriendlyPlace(DogFriendlyPlace place);
        void DeleteDogFriendlyPlace(int id);
        IEnumerable<DogFriendlyPlace> GetAllDogFriendlyPlaces();
        DogFriendlyPlace GetDogFriendlyPlaceById(int id);
        void UpdateDogFriendlyPlace(DogFriendlyPlace place);

    }
}