namespace MultipleChoiceTest.Model.Exceptions;

public class OutOfTestTimeRangeException(string? message) : Exception(message)
{
}