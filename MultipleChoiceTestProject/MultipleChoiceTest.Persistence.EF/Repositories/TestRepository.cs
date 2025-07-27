using Microsoft.EntityFrameworkCore;
using MultipleChoiceTest.Model.Interfaces;
using MultipleChoiceTest.Model.Models;
using MultipleChoiceTest.Persistence.EF.Contexts;

namespace MultipleChoiceTest.Persistence.EF.Repositories;
public class TestRepository(MultipleChoiceTestContext context) :
                            BaseRepository<Test, int>(context), ITestRepository
{
    public async Task<Test?> GetByIdAsync(int id)
    {
        var x =  await context.Set<Test>().Include(t => t.Questions).ThenInclude(t => t.Options).FirstOrDefaultAsync(x => x.Id.Equals(id));
        return x;
    }
}
