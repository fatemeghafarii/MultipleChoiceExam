namespace MultipleChoiceTest.Model.Models;

public class Question : Entity<int>
{
    public string? Text { get; set; }
    public int TestId { get; set; }
    public Test? Test { get; set; }
    public int CorrectOptionOrder { get; set; } //جواب صحیح هر سوال
    public ICollection<Option> Options { get; set; } = new List<Option>();
    public ICollection<Answer> Answers { get; set; } = new List<Answer>();  //هر سوال رو چند تا کاربر جواب دادند
}
