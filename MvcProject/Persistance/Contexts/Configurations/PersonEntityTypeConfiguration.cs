using Domain.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Persistance.Contexts.Configurations
{
    public class PersonEntityTypeConfiguration : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.FullName).HasColumnType("nvarchar").HasMaxLength(200);
            builder.Property(m => m.Experience).HasColumnType("tinyint");
            builder.Property(m => m.DateOfBirth).HasColumnType("date");
            builder.Property(m => m.Location).HasColumnType("nvarchar").HasMaxLength(200);
            builder.Property(m => m.Degree).HasColumnType("int").IsRequired();
            builder.Property(m => m.Bio).HasColumnType("nvarchar").HasMaxLength(4000);
            builder.Property(m => m.Fax).HasColumnType("varchar").HasMaxLength(50);
            builder.Property(m => m.Website).HasColumnType("varchar").HasMaxLength(200);
            builder.Property(m => m.AttachmentPath).HasColumnType("varchar").HasMaxLength(100);
            builder.Property(m => m.CareerLevel).HasColumnType("int").IsRequired();
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();

            builder.HasKey(m => m.Id);
            builder.ToTable("Persons");
        }
    }
}
