using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Mappings;
public class UserTestEntityTypeConfiguration : IEntityTypeConfiguration<UserTest>
{
    public void Configure(EntityTypeBuilder<UserTest> builder)
    {
        builder.HasOne(t => t.User)
               .WithMany(u => u.UserTests)
               .HasForeignKey(a => a.UserId)
               .OnDelete(DeleteBehavior.NoAction);

        builder.HasOne(t => t.Test)
               .WithMany(u => u.UserTests)
               .HasForeignKey(a => a.TestId)
               .OnDelete(DeleteBehavior.NoAction);
    }
}
