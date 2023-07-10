using CanIBringMyDog.Models;
using CanIBringMyDog.Services;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;

namespace CanIBringMyDog.Controllers
{
 
    [Route("api/[controller]")]
    [ApiController]
    public class DogFriendlyPlacesController : ControllerBase  
    {
        private readonly DogFriendlyPlaceService _service;

        public DogFriendlyPlacesController(DogFriendlyPlaceService service)
        {
            _service = service;
        }

        [HttpGet]
        public ActionResult<IEnumerable<DogFriendlyPlace>> GetAll()
        {
            var places = _service.GetAllDogFriendlyPlaces();
            return Ok(places);
        }

        [HttpGet("{id}")]
        public ActionResult<DogFriendlyPlace> GetById(int id)
        {
            var place = _service.GetDogFriendlyPlaceById(id);
            if (place == null)
            {
                return NotFound();
            }
            return Ok(place);
        }

        [HttpPost]
        public ActionResult<DogFriendlyPlace> Create(DogFriendlyPlace place)
        {
            _service.AddDogFriendlyPlace(place);
            return CreatedAtAction(nameof(GetById), new { id = place.Id }, place);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, DogFriendlyPlace place)
        {
            if (id != place.Id)
            {
                return BadRequest();
            }

            _service.UpdateDogFriendlyPlace(place);
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            _service.DeleteDogFriendlyPlace(id);
            return NoContent();
        }
    }
}