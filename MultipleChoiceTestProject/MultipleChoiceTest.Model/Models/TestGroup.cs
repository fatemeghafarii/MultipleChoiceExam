namespace MultipleChoiceTest.Model.Models;

public class TestGroup : Entity<int>
{
    public string? Name { get; set; }
    public ICollection<Test> Tests { get; set; } = new List<Test>();    
}
