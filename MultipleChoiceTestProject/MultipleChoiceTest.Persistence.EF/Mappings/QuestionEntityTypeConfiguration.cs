using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Mappings;
public class QuestionEntityTypeConfiguration : IEntityTypeConfiguration<Question>
{
    public void Configure(EntityTypeBuilder<Question> builder)
    {
        builder.Property(q => q.CorrectOptionOrder)
               .IsRequired();

        builder.HasOne(q => q.Test)
               .WithMany(t => t.Questions)
               .HasForeignKey(e => e.TestId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
