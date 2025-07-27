using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Model.Interfaces;
public interface ITestRepository : IRepository<Test, int>
{
    Task<Test?> GetByIdAsync(int id);
}
