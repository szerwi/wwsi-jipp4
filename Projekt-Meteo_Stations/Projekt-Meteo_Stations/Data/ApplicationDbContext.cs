using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Projekt_Meteo_Stations.Models;

namespace Projekt_Meteo_Stations.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Station>? Station { get; set; }
        public DbSet<StationStatus>? StationStatus { get; set; }
        public DbSet<Projekt_Meteo_Stations.Models.Measurement>? Measurement { get; set; }
    }
}