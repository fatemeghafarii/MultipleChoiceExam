namespace MultipleChoiceTest.Application.Contract.Dtos;
public record TestDto
{
    public int Id { get; set; }
    public DateTime TestDate { get; set; }
    public DateTime StartTime { get; set; }
    public DateTime EndTime { get; set; } 
    public ICollection<QuestionDto> Questions { get; set; } = new List<QuestionDto>();
    public ICollection<AnswerDto> Answers { get; set; } = new List<AnswerDto>();
} 