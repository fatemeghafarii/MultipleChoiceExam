using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Mappings;
public class OptionEntityTypeConfiguration : IEntityTypeConfiguration<Option>
{
    public void Configure(EntityTypeBuilder<Option> builder)
    {
        builder.Property(o => o.Text)
               .IsRequired()
               .HasMaxLength(100)
               .HasColumnType("nvarchar");

        builder.Property(o => o.QuestionId)
               .IsRequired();

        builder.HasOne(t => t.Question)
               .WithMany(c => c.Options)
               .HasForeignKey(e => e.QuestionId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}