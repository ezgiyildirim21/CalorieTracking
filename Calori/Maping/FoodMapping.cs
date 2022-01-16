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
    public class FoodMapping:EntityTypeConfiguration<Food>
    {
        public FoodMapping()
        {
            HasKey(x => x.FoodId)
                .Property(x => x.FoodId)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.FoodName)
                .IsRequired()
                .HasMaxLength(256);

            Property(x => x.Calorie)
                .IsRequired()
                .HasPrecision(5, 2);

            Property(x => x.ImagePath)
                .IsRequired();

            Property(x => x.Porsion)
                .IsRequired();

            Property(x => x.Amount)
                .IsRequired()
                .HasPrecision(5, 2);
        }
    }
}