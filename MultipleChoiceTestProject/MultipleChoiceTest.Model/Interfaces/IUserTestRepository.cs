namespace MultipleChoiceTest.Model.Interfaces;
public interface IUserTestRepository
{
    Task<bool> ExistsAsync(int userId, int testId);
}
