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
    public class CategoryEntityTypeConfiguration : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.Property(m => m.Id).HasColumnType("int").UseIdentityColumn(1, 1);
            builder.Property(m => m.Name).HasColumnType("nvarchar").HasMaxLength(200);
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.CreatedAt).HasColumnType("datetime").IsRequired();
            builder.Property(m => m.CreatedBy).HasColumnType("int").IsRequired();
            builder.Property(m => m.LastModifiedAt).HasColumnType("datetime");
            builder.Property(m => m.LastModifiedBy).HasColumnType("int").IsRequired(false);
            builder.Property(m => m.DeletedAt).HasColumnType("datetime");
            builder.Property(m => m.DeletedBy).HasColumnType("int").IsRequired(false);

            builder.HasKey(m => m.Id);
            builder.ToTable("Categories");
        }
    }
}
