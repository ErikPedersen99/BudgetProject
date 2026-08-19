using Domain.Entities;

namespace Domain.Interfaces;

public interface IRecurringTransactionRepository : IRepository<RecurringTransaction>
{
    Task<IEnumerable<RecurringTransaction>> GetByUserIdAsync(Guid userId);
    Task<IEnumerable<RecurringTransaction>> GetDueOnOrBeforeAsync(DateTime date);
}