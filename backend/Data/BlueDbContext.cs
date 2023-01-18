using Blue.Data.Mappings;
using Blue.Models;
using Microsoft.EntityFrameworkCore;

namespace Blue.Data
{
    public class BlueDbContext : DbContext
    {
        public DbSet<Agenda> Agendas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlServer("Server=localhost,1433;Database=Blue;User ID=sa;Password=root; TrustServerCertificate=True");

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AgendaMap());
      
        }
    }
}
