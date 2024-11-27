using Microsoft.EntityFrameworkCore;
using VeterinariaPichichus.Models;

namespace VeterinariaPichichus.Context
{
    public class DuenioContext : DbContext
    {
        public DbSet<Duenio> Duenios { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{

        //    optionsBuilder.UseSqlServer("Data Source = MOURINOOS\\AXSQLEXPRESS ; Initial Catalog = Veterinaria;  Encrypt= true;trustservercertificate =true; Integrated Security = true");
        //}

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            
            modelBuilder.Entity<Duenio>()
                .HasOne(d => d.MascotaDuenio)
                .WithOne(m => m.Duenio)
                .HasForeignKey<Duenio>(d => d.MascotaId);
        }
    }
}
