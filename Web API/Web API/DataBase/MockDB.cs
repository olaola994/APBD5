using Web_API.Models;

namespace Web_API.DataBase;

public class MockDB
{
    public List<Animal> Animals { get; set; } = new List<Animal>();

    public List<Visit> Visits { get; set; } = new List<Visit>();
    public MockDB()
    {
        Animals.Add(new Animal{Id = 1, Name = "Charlie", Category = "dog", Color = "brown", Weight = 5});
        Animals.Add(new Animal{Id = 2, Name = "Antoniusz", Category = "dog", Color = "white", Weight = 1});
        Animals.Add(new Animal{Id = 3, Name = "Mia", Category = "cat", Color = "black", Weight = 6});
        Animals.Add(new Animal{Id = 4, Name = "Mela", Category = "horse", Color = "brown", Weight = 500});
        Animals.Add(new Animal());
        
        Visits.Add(new Visit{ Id = 1, VisitDate = DateTime.Now.AddDays(-17), Description = "Vaccine", Price = 50, Animal = Animals[0]});
        Visits.Add(new Visit{ Id = 2, VisitDate = DateTime.Now.AddDays(-10), Description = "General health check", Price = 100, Animal = Animals[1]});
        Visits.Add(new Visit{ Id = 3, VisitDate = DateTime.Now.AddDays(-7), Description = "Vaccine", Price = 50, Animal = Animals[2]});
        Visits.Add(new Visit{ Id = 4, VisitDate = DateTime.Now.AddDays(-20), Description = "General health chec", Price = 100, Animal = Animals[2]});
        Visits.Add(new Visit{ Id = 5, VisitDate = DateTime.Now.AddDays(-3), Description = "General health check", Price = 100, Animal = Animals[3]});
        Visits.Add(new Visit{ Id = 6, VisitDate = DateTime.Now.AddDays(-1), Description = "Vaccine", Price = 50, Animal = Animals[1]});
    }
}