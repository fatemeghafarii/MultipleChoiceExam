using Microsoft.EntityFrameworkCore;
using MultipleChoiceTest.Model.Interfaces;
using MultipleChoiceTest.Model.Models;

namespace MultipleChoiceTest.Persistence.EF.Repositories;
public abstract class BaseRepository<TAggregate, TKey>(DbContext context) : IRepository<TAggregate, TKey> where TAggregate : Entity<TKey>
{
    private readonly DbContext _context = context;
    public virtual async Task<bool> ExistsAsync(TKey id)
    {
        return await _context.Set<TAggregate>().AnyAsync(t => t.Id!.Equals(id));
    }
}

