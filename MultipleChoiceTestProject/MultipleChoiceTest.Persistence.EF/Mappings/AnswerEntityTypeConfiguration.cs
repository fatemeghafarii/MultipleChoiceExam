using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Mappings;
public class AnswerEntityTypeConfiguration : IEntityTypeConfiguration<Answer>
{
    public void Configure(EntityTypeBuilder<Answer> builder)
    {
        builder.Property(a => a.QuestionId)
               .IsRequired();

        builder.Property(a => a.UserId)
               .IsRequired();

        builder.Property(a => a.SelectedOption)
               .IsRequired();

        builder.Property(a => a.SubmittedAt)
               .IsRequired();

        builder.HasOne(t => t.Question)
               .WithMany(c => c.Answers)
               .HasForeignKey(e => e.QuestionId);

        builder.HasOne(t => t.User)
               .WithMany(c => c.Answers)
               .HasForeignKey(e => e.UserId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}

