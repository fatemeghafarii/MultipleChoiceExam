using Microsoft.EntityFrameworkCore;
using MultipleChoiceTest.Model.Interfaces;
using MultipleChoiceTest.Model.Models;
using MultipleChoiceTest.Persistence.EF.Contexts;

namespace MultipleChoiceTest.Persistence.EF.Repositories;
public class UserTestRepository(MultipleChoiceTestContext context) :
                            BaseRepository<UserTest, int>(context), IUserTestRepository
{
    public async Task<bool> ExistsAsync(int userId, int testId)
    {
        return await context.Set<UserTest>().AnyAsync(a => a.UserId!.Equals(userId) && a.TestId.Equals(testId));
    }
}
