using Calori.Maping;
using Calori.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori.Data
{
    public class AppDbContext:DbContext
    {
        public AppDbContext() : base("server=.;database=CaloriAppDb;trusted_connection=true")
        {

        }
        public DbSet<Food>Foods { get; set; }
        public DbSet<Meal>Meals{ get; set; }
        public DbSet<User> Users { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new FoodMapping());
            modelBuilder.Configurations.Add(new CategoryMapping());
            modelBuilder.Configurations.Add(new UserMapping());
            modelBuilder.Configurations.Add(new MealMapping());

            base.OnModelCreating(modelBuilder);
        }

    }
}
