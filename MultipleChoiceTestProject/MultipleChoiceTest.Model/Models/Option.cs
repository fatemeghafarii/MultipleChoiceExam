namespace MultipleChoiceTest.Model.Models;

public class Option : Entity<int>
{
    public int Order { get; set; }// مثلاً 1 تا 4
    public string? Text { get; set; }
    public int QuestionId { get; set; }
    public Question? Question { get; set; }
}
