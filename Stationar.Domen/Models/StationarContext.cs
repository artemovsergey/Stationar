using Microsoft.EntityFrameworkCore;

namespace Stationar.Domen.Models;

public class StationarContext : DbContext
{

    public DbSet<Patient> Patients { get; set; }
    public DbSet<Departament> Departaments { get; set; }
    public DbSet<Place> Places { get; set; }
    public DbSet<Room> Rooms { get; set; }

    public StationarContext()
    {
        Database.Migrate();
    }
    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        //optionsBuilder.UseSqlServer("Server=(localdb)\\Mssqllocaldb;Database=StationarDatabase;Trusted_Connection=true");
        optionsBuilder.UseSqlServer("Server=sql.stud.scc;Database=StationarDatabase;User=asv;Password=asv202;TrustServerCertificate=True");
    }

}
