using Microsoft.AspNetCore.Mvc;
using Web_API.DataBase;
using Web_API.Models;

namespace Web_API.Controllers;
[Route("/visit-controller")]
public class VisitControllers : ControllerBase
{
    private readonly MockDB _db;

    public VisitControllers(MockDB db)
    {
        _db = db;
    }

    [HttpGet]
    public IActionResult GetVisits()
    {
       return Ok(_db.Visits);
    }

    [HttpGet("{id}")]
    public IActionResult GetVisitById(int id)
    {
        var Visit = _db.Visits.FirstOrDefault(v => id == v.Id);
        if (Visit == null)
        {
            return NotFound();
        }
        return Ok(Visit);
    }

    [HttpPost]
    public IActionResult AddVisit(Visit visit)
    {
        _db.Visits.Add(visit);
        return Created();
    }
}