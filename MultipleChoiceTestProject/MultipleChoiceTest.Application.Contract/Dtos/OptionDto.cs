namespace MultipleChoiceTest.Application.Contract.Dtos;
public record OptionDto
{
    public int Id { get; set; }
    public int Order { get; set; }
    public string? Text { get; set; }
}
