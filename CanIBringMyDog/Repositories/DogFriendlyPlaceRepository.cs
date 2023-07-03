using System.Collections.Generic;
using System.Linq;

public class DogFriendlyPlaceRepository
{
    //medlem readonly=const i detta fallet privat _litenbokstav
    private readonly AppDbContext _context;

    //Construktor
    public DogFriendlyPlaceRepository(AppDbContext context)
    {
        _context = context;
    }

    public IEnumerable<DogFriendlyPlace> GetAll()
    {
        return _context.DogFriendlyPlaces.ToList();
    }

    public DogFriendlyPlace GetById(int id)
    {
        return _context.DogFriendlyPlaces.FirstOrDefault(p => p.Id == id);
    }

    public void Add(DogFriendlyPlace place)
    {
        _context.DogFriendlyPlaces.Add(place);
        _context.SaveChanges();
    }

    public void Update(DogFriendlyPlace place)
    {
        _context.DogFriendlyPlaces.Update(place);
        _context.SaveChanges();
    }

    public void Delete(int id)
    {
        var place = _context.DogFriendlyPlaces.FirstOrDefault(p => p.Id == id);
        if (place != null)
        {
            _context.DogFriendlyPlaces.Remove(place);
            _context.SaveChanges();
        }
    }
}
