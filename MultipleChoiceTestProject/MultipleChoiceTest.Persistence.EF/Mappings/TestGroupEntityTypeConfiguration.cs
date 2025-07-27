using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Mappings;
public class TestGroupEntityTypeConfiguration : IEntityTypeConfiguration<TestGroup>
{
    public void Configure(EntityTypeBuilder<TestGroup> builder)
    {
        builder.Property(t => t.Name)
              .IsRequired()
              .HasMaxLength(100)
              .HasColumnType("nvarchar");
    }
}