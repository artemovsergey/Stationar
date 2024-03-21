namespace Stationar.Domen.Models;

public class Place : Base
{

    public int? PatientId { get; set; } = null;
    public Patient? Patient { get; set; } = null;


    public int RoomId { get; set; }
    public Room Room { get; set; }



}
