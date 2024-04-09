using Web_API.Models;

namespace Web_API.DataBase;

public class StaticData
{
    public static List<Animal> animals = new()
    {
        new Animal(),
        new Animal(),
        new Animal()
    };
}