using System.Collections.Generic;

public class DogFriendlyPlaceService
{
    private readonly DogFriendlyPlaceRepository _repository;

    public DogFriendlyPlaceService(DogFriendlyPlaceRepository repository)
    {
        _repository = repository;
    }

    public IEnumerable<DogFriendlyPlace> GetAllDogFriendlyPlaces()
    {
        return _repository.GetAll();
    }

    public DogFriendlyPlace GetDogFriendlyPlaceById(int id)
    {
        return _repository.GetById(id);
    }

    public void AddDogFriendlyPlace(DogFriendlyPlace place)
    {
        _repository.Add(place);
    }

    public void UpdateDogFriendlyPlace(DogFriendlyPlace place)
    {
        _repository.Update(place);
    }

    public void DeleteDogFriendlyPlace(int id)
    {
        _repository.Delete(id);
    }
}
