using Domain.Entities;

namespace Domain.Interfaces;

public interface IBudgetRepository : IRepository<Budget>
{
    Task<IEnumerable<Budget>> GetByUserAndPeriodAsync(Guid userId, int month, int year);
    Task<Budget?> GetByUserCategoryPeriodAsync(Guid userId, Guid categoryId, int month, int year);
}