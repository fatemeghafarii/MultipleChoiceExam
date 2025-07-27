namespace MultipleChoiceTest.Application.Contract.Dtos;
public record AnswerDto
{
    public DateTime SubmittedAt { get; set; } = DateTime.Now;   
    public int? SelectedOption { get; set; }
    public int UserId { get; set; }
    public int QuestionId { get; set; }
    public int TestId { get; set; }
}
