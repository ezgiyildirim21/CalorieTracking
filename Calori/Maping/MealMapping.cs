using Calori.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calori.Maping
{
    public class MealMapping : EntityTypeConfiguration<Meal>
    {
        public MealMapping()
        {
            HasKey(x => x.MealId)
                .Property(x => x.MealId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.MealName)
                .IsRequired();
        }
    }
}
