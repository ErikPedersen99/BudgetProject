using Domain.Entities;

namespace Domain.Interfaces;

public interface ICategoryRepository : IRepository<Category>
{
    Task<IEnumerable<Category>> GetByUserIdAsync(Guid userId);
    Task<Category?> GetByUserandNameAsync(Guid userId, string name);
}