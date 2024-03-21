namespace Stationar.Domen.Models;

public class Room : Base
{
    public int Number { get; set; }

    public int DepartamentId { get; set; }
    public Departament? Departement { get; set; } = null;



    public IEnumerable<Place>? Places { get; set; } = null;
}
