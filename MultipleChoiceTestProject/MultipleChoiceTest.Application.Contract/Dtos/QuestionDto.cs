namespace MultipleChoiceTest.Application.Contract.Dtos;
public record QuestionDto
{
    public int Id { get; set; }
    public string? Text { get; set; }
    public int TestId { get; set; }
    public ICollection<OptionDto> Options { get; set; } = new List<OptionDto>();
}
