using Core.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Repository
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }//options almasının sebebi bu optionsla beraber veri tabanı yolunu startup dosyasından veriyoruz

        public DbSet<Collection>    Collections { get; set; }
        public DbSet<Genre> Genres { get; set; }
        public DbSet<Movie> Movies { get; set; }
        public DbSet<ProductionCountries> ProductionCountries { get; set; }
        public DbSet<ProductionCompanies> ProductionCompanies { get; set; }
        public DbSet<SpokenLanguages> SpokenLanguages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
            base.OnModelCreating(modelBuilder);
        }
    }
}
