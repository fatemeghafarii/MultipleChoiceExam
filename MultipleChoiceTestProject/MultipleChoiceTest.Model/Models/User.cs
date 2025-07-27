namespace MultipleChoiceTest.Model.Models;

public class User : Entity<int>
{
    public string? Name { get; set; }
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    public ICollection<UserTest> UserTests { get; set; } = new List<UserTest>();
}
