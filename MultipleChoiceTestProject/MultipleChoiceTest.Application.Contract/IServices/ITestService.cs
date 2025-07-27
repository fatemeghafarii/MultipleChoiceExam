using MultipleChoiceTest.Application.Contract.Dtos;
using MultipleChoiceTest.Application.Contract.ViewModels;

namespace MultipleChoiceTest.Application.Contract.IServices;
public interface ITestService
{
    Task<bool> CheckInputsForShowTest(RequestDto input);
    Task SubmitAnswerAsync(TestDto dto, int userId);
    Task<TestDto> GetTestWithQuestionsAsync(int testId);
}
