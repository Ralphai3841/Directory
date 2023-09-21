using Directory.MODEL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Directory.MAP.Configuration
{
    public class PersonConfiguration : IEntityTypeConfiguration<Person>
    {
        // firstname kolonu zorunlu ve max 15 karakter 
        // telefon kolonu zorunlu ve max 15 karakter
        // lastname  max 15 karakter
        // company  max 15 karakter

        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(X => X.FirstName).IsRequired().HasMaxLength(15);
            builder.Property(X => X.LastName).HasMaxLength(15);
            builder.Property(X => X.PhoneNumber).HasMaxLength(15).IsRequired();
            builder.Property(X => X.Company).HasMaxLength(15);
        }
    }
}
