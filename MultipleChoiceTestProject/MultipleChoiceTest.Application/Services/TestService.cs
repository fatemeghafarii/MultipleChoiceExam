using AutoMapper;
using MultipleChoiceTest.Application.Contract.Dtos;
using MultipleChoiceTest.Application.Contract.IServices;
using MultipleChoiceTest.Application.Contract.ViewModels;
using MultipleChoiceTest.Model.Exceptions;
using MultipleChoiceTest.Model.Interfaces;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Application.Services;
public class TestService(ITestRepository testRepository, IAnswerRepository answerRepository, IUserTestRepository userTestRepository, IMapper mapper) : ITestService
{
    private readonly ITestRepository _testRepository = testRepository;
    private readonly IAnswerRepository _answerRepository = answerRepository;
    private readonly IUserTestRepository _userTestRepository = userTestRepository;
    private readonly IMapper _mapper = mapper;

    public async Task<bool> CheckInputsForShowTest(RequestDto input)
    {
        var isExist = await _userTestRepository.ExistsAsync(input.UserId, input.TestId);
        return isExist;
    }
    public async Task SubmitAnswerAsync(TestDto dto, int userId)
    {
        //if (DateTime.Now < dto.StartTime || DateTime.Now > dto.EndTime || DateTime.Now.Date != dto.StartTime.Date)
        //    throw new OutOfTestTimeRangeException("آزمون در بازه زمانی معتبر نیست.");

        var answers = dto.Answers.Select(x => new Answer
        {
            QuestionId = x.QuestionId,
            UserId = userId,
            SelectedOption = x.SelectedOption,
            SubmittedAt = x.SubmittedAt,
            TestId = dto.Id,
        }).ToList();

        var isUserIdAndTestIdInAnswer = await _answerRepository.ExistsAsync(userId, dto.Id);
        if (isUserIdAndTestIdInAnswer)
        {
            throw new OutOfTestTimeRangeException("کاربر قبلاً در این آزمون شرکت کرده است و مجاز به ارسال مجدد نیست");
        }
        await _answerRepository.CreateAsync(answers);
        await _answerRepository.SaveChangesAsync();
    }
    public async Task<TestDto> GetTestWithQuestionsAsync(int testId)
    {
        var test = await _testRepository.GetByIdAsync(testId);
        var mappedTestDto = _mapper.Map<TestDto>(test);
        return mappedTestDto;
    }
}
