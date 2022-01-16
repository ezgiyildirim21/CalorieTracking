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
    public class UserMapping : EntityTypeConfiguration<User>
    {
        public UserMapping()
        {
            HasKey(x => x.Id)
                .Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            Property(x => x.Name)
                .IsRequired()
                .HasMaxLength(256);

            Property(x => x.Surname)
                .IsRequired()
                .HasMaxLength(256);

            Property(x => x.Email)
                .IsRequired()
                .HasMaxLength(256);

            Property(x => x.Password)
                .IsRequired()
                .HasMaxLength(256);

            Property(x => x.BirthDate)
                .IsRequired();

            Property(x => x.Weight)
                .HasPrecision(5, 2);

            Property(x => x.Height)
                .HasPrecision(5, 2);

            Property(x => x.Gender)
                .IsRequired();
        }
    }
}
