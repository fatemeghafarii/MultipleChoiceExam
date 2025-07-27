namespace MultipleChoiceTest.Model.Models;

public partial class Test : Entity<int>
{
    public DateTime TestDate { get; set; } //not null
    public DateTime StartTime { get; set; } //not null
    public DateTime EndTime {get; set; } //not null
    public int TestGroupId { get; set; }
    public TestGroup? TestGroup { get; set; } //not null
    public ICollection<Question> Questions { get; set; } = new List<Question>();
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();
    public ICollection<UserTest> UserTests { get; set; } = new List<UserTest>();
}
