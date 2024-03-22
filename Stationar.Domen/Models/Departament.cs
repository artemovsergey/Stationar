namespace Stationar.Domen.Models;

public class Departament : Base
{
    public string Name { get; set; }

    public IEnumerable<Room> Rooms { get; set; } = null;

}
