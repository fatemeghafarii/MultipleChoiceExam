using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Mappings;

public class TestEntityTypeConfiguration : IEntityTypeConfiguration<Test>
{
    public void Configure(EntityTypeBuilder<Test> builder)
    {
        builder.Property(t => t.TestGroupId)
               .IsRequired();

        builder.Property(t => t.TestDate)
               .IsRequired();

        builder.Property(t => t.StartTime)
               .IsRequired();

        builder.Property(t => t.EndTime)
               .IsRequired();

        builder.HasOne(t => t.TestGroup)
               .WithMany(c => c.Tests)
               .HasForeignKey(e => e.TestGroupId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}

