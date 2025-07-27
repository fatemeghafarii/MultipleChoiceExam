using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Model.Interfaces;
public interface IRepository<TAggregate, TKey> where TAggregate : Entity<TKey>
{
    Task<bool> ExistsAsync(TKey id);
}
