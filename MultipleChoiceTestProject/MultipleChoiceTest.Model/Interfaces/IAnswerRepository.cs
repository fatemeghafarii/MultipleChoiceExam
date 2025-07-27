using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Model.Interfaces;
public interface IAnswerRepository : IRepository<Answer, int>
{
    Task CreateAsync(List<Answer> answers);
    Task SaveChangesAsync();
    Task<bool> ExistsAsync(int userId, int testId);
}
