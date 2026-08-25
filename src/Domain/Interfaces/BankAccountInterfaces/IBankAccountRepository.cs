using Domain.Entities;

namespace Domain.Interfaces;

public interface IBankAccountRepository : IRepository<BankAccount>
{
    Task<IEnumerable<BankAccount>> GetByUserIdAsync(Guid userId);
    Task<BankAccount?> GetByExternalIdAsync(string externalId);
}