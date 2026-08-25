using Microsoft.EntityFrameworkCore;
using Domain.Entities;
using Domain.Interfaces;

namespace Infrastructure.Repositories;

public class BankAccountRepository : Repository<BankAccount>, IBankAccountRepository
{
    public BankAccountRepository(AppDbContext context) : base(context) {}

    public async Task<IEnumerable<BankAccount>> GetByUserIdAsync(Guid userId) =>
    await _dbSet.Where(b => b.UserId == userId).ToListAsync();
    
    public async Task<BankAccount?> GetByExternalIdAsync(string externalId) =>
    await _dbSet.FirstOrDefaultAsync(b => b.ExternalId == externalId);
}