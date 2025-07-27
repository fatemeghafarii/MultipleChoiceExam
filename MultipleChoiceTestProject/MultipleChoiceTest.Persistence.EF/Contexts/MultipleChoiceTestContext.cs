using Microsoft.EntityFrameworkCore;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Contexts;
public class MultipleChoiceTestContext(DbContextOptions<MultipleChoiceTestContext> options) : DbContext(options)
{
    public DbSet<Answer> Answer { get; set; }
    public DbSet<Option> Option { get; set; }
    public DbSet<Question> Question { get; set; }
    public DbSet<Test> Test { get; set; }
    public DbSet<TestGroup> TestGroup { get; set; }
    public DbSet<User> User { get; set; }
    public DbSet<UserTest> UserTest { get; set; }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
    }
}
