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
    public class ProjectCategoryEntityTypeConfiguration : IEntityTypeConfiguration<ProjectCategory>
    {
        public void Configure(EntityTypeBuilder<ProjectCategory> builder)
        {

            builder.Property(m => m.ProjectId).HasColumnType("int");
            builder.Property(m => m.CategoryId).HasColumnType("int");

            builder.HasNoKey();
            builder.ToTable("ProjectCategories");


            builder.HasOne<Project>()
                .WithMany()
                .HasPrincipalKey(m => m.Id)
                .HasForeignKey(m => m.ProjectId)
                .OnDelete(DeleteBehavior.NoAction);


            builder.HasOne<Category>()
                .WithMany()
                .HasPrincipalKey(m => m.Id)
                .HasForeignKey(m => m.CategoryId)
                .OnDelete(DeleteBehavior.NoAction);

        }
    }
}
