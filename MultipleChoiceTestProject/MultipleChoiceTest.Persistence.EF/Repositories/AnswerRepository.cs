using Microsoft.EntityFrameworkCore;
using MultipleChoiceTest.Model.Interfaces;
using MultipleChoiceTest.Model.Models;
using MultipleChoiceTest.Persistence.EF.Contexts;

namespace MultipleChoiceTest.Persistence.EF.Repositories;
public class AnswerRepository(MultipleChoiceTestContext context) :
                            BaseRepository<Answer, int>(context), IAnswerRepository
{
    public async Task CreateAsync(List<Answer> answers)
    {
        await context.Answer.AddRangeAsync(answers);
    }

    public async Task<bool> ExistsAsync(int userId, int testId)
    {
        return await context.Set<Answer>().AnyAsync(a => a.UserId!.Equals(userId) && a.TestId.Equals(testId));
    }

    public async Task SaveChangesAsync()
    {
        await context.SaveChangesAsync();
    }
}
