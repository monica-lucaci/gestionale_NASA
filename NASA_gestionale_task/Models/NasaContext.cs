using Microsoft.EntityFrameworkCore;

namespace NASA_gestionale_task.Models
{
    public class NasaContext : DbContext
    {
        public NasaContext(DbContextOptions<NasaContext> options) : base(options)
        {

        }

        public DbSet<OggettoCeleste> OggettiCelesti { get; set; }
        public DbSet<Sistema> Sistemi { get; set; }
    }
}
