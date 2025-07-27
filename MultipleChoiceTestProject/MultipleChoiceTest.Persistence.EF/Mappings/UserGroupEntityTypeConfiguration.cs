using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Mappings;
internal class UserGroupEntityTypeConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.Property(u => u.Name)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnType("nvarchar");
    }
}

