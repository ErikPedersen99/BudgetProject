using Domain.Entities;

namespace Domain.Interfaces;

public interface ICategoryRuleRepository : IRepository<CategoryRule>
{
    Task<IEnumerable<CategoryRule>> GetByUserIdAsync(Guid userId);
    Task<IEnumerable<CategoryRule>> GetByCategoryIdAsync(Guid categoryId);
}