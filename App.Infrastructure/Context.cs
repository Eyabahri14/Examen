using App.ApplicationCore.Domain;
using App.Infrastructure.Configurations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App.Infrastructure
{
    public class Context : DbContext
    {

        public DbSet<Prestataire> Prestataires { get; set; }
        public DbSet<Prestation> Prestations { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<RDV> RDVs { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.
                UseLazyLoadingProxies().
                UseSqlServer(this.GetJsonConnectionString("appsettings.json"));
            base.OnConfiguring(optionsBuilder);
        }
        protected override void ConfigureConventions(ModelConfigurationBuilder configurationBuilder)
        {

            // Pre-convention model configuration goes here
            configurationBuilder
                 .Properties<string>()
               .HaveMaxLength(150);
            base.ConfigureConventions(configurationBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.ApplyConfiguration(new RDVConfiguration());
        }
    }
}
