using Microsoft.AspNetCore.Mvc;
using Web_API.DataBase;
using Web_API.Models;

namespace Web_API.Controllers;


[ApiController]
[Route("/animals-controller")]
public class AnimalController : ControllerBase
{
    private readonly MockDB _db; 
    public AnimalController(MockDB db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetAnimals()
    {
        return Ok(_db.Animals);
    }

    [HttpGet("{id}")]
    public IActionResult GetAnimalById(int id)
    {
        var animal = _db.Animals.FirstOrDefault(a => id == a.Id);
        if (animal == null)
        {
            return NotFound();
        }

        return Ok(animal);
    }
    
    [HttpPost]
    public IActionResult AddAnimals(Animal animal)
    {
        _db.Animals.Add(animal);
        return Created();
    }

    [HttpPut("{id}")]
    public IActionResult UpdateAnimal(int id, Animal UpdatedAnimal)
    {
        var animal = _db.Animals.FirstOrDefault(a => id == a.Id);
        if (animal == null)
        {
            return NotFound();
        }

        animal.Name = UpdatedAnimal.Name;
        animal.Category = UpdatedAnimal.Category;
        animal.Weight = UpdatedAnimal.Weight;
        animal.Color = UpdatedAnimal.Color;
        return Ok(animal);
    }

    [HttpDelete("{id}")]
    public IActionResult DeleteAnimal(int id)
    {
        var animal = _db.Animals.FirstOrDefault(a => id == a.Id);
        if (animal == null)
        {
            return NotFound();
        }

        _db.Animals.Remove(animal);

        return NoContent();
    }
}