using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Model.Interfaces
{
    public interface IUserRepository : IRepository<User, int>
    {
        new Task<bool> ExistsAsync(int id);
    }
}
