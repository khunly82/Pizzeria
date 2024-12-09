using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pizzeria.DAL.Models;

namespace Pizzeria.DAL
{
    public class PizzeriaContext : DbContext
    {
        // Représentation des tables de la base de données
        #region DbSet
        public DbSet<Pizza> Pizzas { get; set; }
        public DbSet<Ingredient> Ingredients { get; set; }
        public DbSet<Commande> Commandes { get; set; }
        public DbSet<CommandLine> CommandeLines { get; set; }
        public DbSet<Client> Clients { get; set; }
        public DbSet<Adresse> Adresse { get; set; }

        #endregion

        #region Constructors
        public PizzeriaContext()
        {
        }

        public PizzeriaContext(DbContextOptions options) : base(options) 
        { 
        }
        #endregion

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // si windows authentication integrated security=true
            // si authentication sql uid=sa;pwd=test1234=

            IConfigurationBuilder builder = new ConfigurationBuilder();
            builder.AddJsonFile("appsettings.json");
            IConfiguration configuration = builder.Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Main"));
        }
    }
}
